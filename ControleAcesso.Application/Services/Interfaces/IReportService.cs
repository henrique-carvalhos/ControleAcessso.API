using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;

namespace ControleAcessso.API.Services.Interfaces
{
    public interface IReportService
    {
        List<Report> GetAll();
        ReportViewModel GetById(int id);
        void Update(UpdateReportInputModel inputModel);
        void Delete(int id);
        int Create(NewReportInputModel inputModel);
    }
}
