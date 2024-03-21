using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;
using ControleAcessso.API.InputModels;

namespace ControleAcessso.API.Services.Interfaces
{
    public interface IGroupReportService
    {
        List<GroupReport> GetAll();
        List<GroupReportViewModel> GetById(int id);
        int Create(NewGroupReportInputModel inputModel);
        void Update(UpdateGroupReportInputModel inputModel);
    }
}
