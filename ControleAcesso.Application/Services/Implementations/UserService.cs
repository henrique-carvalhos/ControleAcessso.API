using ControleAcessso.API.Entities;
using ControleAcessso.API.InputModels;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;
using ControleAcessso.API.ViewModels;
using System.Text.RegularExpressions;

namespace ControleAcessso.API.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public UserService(ControleAcessoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.Nome, inputModel.Login, inputModel.Senha, inputModel.IdGroup, Enums.StatusEnum.Ativo);

            return user.Id;
        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            user.Delete();
        }

        public List<User> GetAll()
        {
            var users = _dbContext.Users;

            return users.ToList();
        }

        public List<UserViewModel> GetAllViewModel(int id)
        {
            var userViewModels = from usuario in _dbContext.Users
                                 where usuario.Id == id
                                 join grupoRelatorio in _dbContext.GruposRelatorios on usuario.IdGroup equals grupoRelatorio.IdGroup
                                 join grupo in _dbContext.Groups on grupoRelatorio.IdGroup equals grupo.Id
                                 join relatorio in _dbContext.Relatorios on grupoRelatorio.IdRelatorio equals relatorio.Id
                                 select new UserViewModel
                                 {
                                     Usuario = usuario.Nome,
                                     Grupo = grupo.Descricao,
                                     Relatorio = relatorio.Descricao,
                                     CodRelatorio = relatorio.CodRelatorio
                                 };

            return userViewModels.ToList();
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == inputModel.Id);

            user?.Update(inputModel.Nome, inputModel.Login, inputModel.Senha, inputModel.IdGroup);
        }
    }
}
