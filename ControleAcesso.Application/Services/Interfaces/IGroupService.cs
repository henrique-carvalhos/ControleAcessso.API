using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;

namespace ControleAcessso.API.Services.Interfaces
{
    public interface IGroupService
    {
        List<Group> GetAll();
        GroupViewModel GetById(int id);
        void Update(UpdateGroupInputModel inputModel);
        void Delete(int id);
        int Create(NewGroupInputModel inputModel);
    }
}
