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
            var groupReports = _dbContext.GroupsReports.Where(r => r.IdGroup == id).ToList();

            if (groupReports.Count == 0)
                return null;

            var groupReportViewModels = new List<GroupReportViewModel>();

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

        public void Update(UpdateGroupReportInputModel inputModel)
        {
            var groupReport = _dbContext.GroupsReports.SingleOrDefault(u => u.Id == inputModel.Id);

            groupReport?.Update(inputModel.IdGroup, inputModel.IdRelatorio);

            _dbContext.SaveChanges();
        }
    }
}
