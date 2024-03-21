using ControleAcesso.Application.InputModels;
using ControleAcesso.Application.ViewModels;
using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class GroupReportService : IGroupReportService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public GroupReportService(ControleAcessoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewGroupReportInputModel inputModel)
        {
            var groupReport = new GroupReport(inputModel.IdGroup, inputModel.IdRelatorio);

            _dbContext.GroupsReports.Add(groupReport);
            _dbContext.SaveChanges();

            return groupReport.Id;
        }

        public List<GroupReport> GetAll()
        {
            var groupReport = _dbContext.GroupsReports;

            return groupReport.ToList();
        }

        public List<GroupReportViewModel> GetById(int id)
        {
            // Consulta para obter todos os GroupReports com o idGroup correspondente
            var groupReports = _dbContext.GroupsReports.Where(r => r.IdGroup == id).ToList();

            // Verifica se a lista de groupReports está vazia, o que significa que não foram encontrados registros
            if (groupReports.Count == 0)
                return null;

            // Cria uma lista de GroupReportViewModel para armazenar os resultados
            var groupReportViewModels = new List<GroupReportViewModel>();

            // Itera sobre os groupReports encontrados e cria um GroupReportViewModel para cada um
            foreach (var groupReport in groupReports)
            {
                var groupReportViewModel = new GroupReportViewModel
                {
                    Id = groupReport.Id,
                    IdGroup = groupReport.IdGroup,
                    IdRelatorio = groupReport.IdRelatorio
                };
                groupReportViewModels.Add(groupReportViewModel);
            }

            return groupReportViewModels;
        }

    }
}
