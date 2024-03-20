using ControleAcessso.API.Entities;
using ControleAcessso.API.InputModels;
using ControleAcessso.API.ViewModels;

namespace ControleAcessso.API.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        List<UserViewModel> GetAllViewModel(int id);
        void Update(UpdateUserInputModel inputModel);
        void Delete(int id);
        int Create(NewUserInputModel inputModel);
    }
}
