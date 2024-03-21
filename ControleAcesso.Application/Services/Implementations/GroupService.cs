using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class GroupService : IGroupService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public GroupService(ControleAcessoDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public int Create(NewGroupInputModel inputModel)
        {
            var group = new Group(inputModel.Descricao);

            _dbContext.Add(group);
            _dbContext.SaveChanges();

            return group.Id;
        }

        public void Delete(int id)
        {
            var group = _dbContext.Groups.SingleOrDefault(u => u.Id == id);

            group?.Delete();

            _dbContext.SaveChanges();
        }

        public List<Group> GetAll()
        {
            var groups = _dbContext.Groups;

            return groups.ToList();
        }

        public GroupViewModel GetById(int id)
        {
            var group = _dbContext.Groups.SingleOrDefault(x => x.Id == id);

            if (group == null) return null;

            var reportViewModel = new GroupViewModel(
                        group.Id,
                        group.Descricao
                );

            return reportViewModel;
        }

        public void Update(UpdateGroupInputModel inputModel)
        {
            var group = _dbContext.Groups.SingleOrDefault(u => u.Id == inputModel.Id);

            group?.Update(inputModel.Descricao);

            _dbContext.SaveChanges();
        }
    }
}
