using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public ReportService(ControleAcessoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewReportInputModel inputModel)
        {
            var report = new Report(inputModel.CodRelatorio, inputModel.Descricao);

            _dbContext.Reports.Add(report);
            _dbContext.SaveChanges();

            return report.Id;
        }

        public void Delete(int id)
        {
            var report = _dbContext.Reports.SingleOrDefault(u => u.Id == id);

            report?.Delete();

            _dbContext.SaveChanges();
        }

        public List<Report> GetAll()
        {
            var relatorios = _dbContext.Reports;

            return relatorios.ToList();
        }

        public ReportViewModel GetById(int id)
        {
            var relatorio = _dbContext.Reports.SingleOrDefault(x => x.Id == id);

            if (relatorio == null) return null;

            var reportViewModel = new ReportViewModel(
                        relatorio.Id,
                        relatorio.CodRelatorio,
                        relatorio.Descricao
                );

            return reportViewModel;
        }

        public void Update(UpdateReportInputModel inputModel)
        {
            var report = _dbContext.Reports.SingleOrDefault(u => u.Id == inputModel.Id);

            report?.Update(inputModel.CodRelatorio, inputModel.Descricao);

            _dbContext.SaveChanges();
        }
    }
}
