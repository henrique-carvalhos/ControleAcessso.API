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

        public List<GroupReport> GetAll()
        {
            var grupoRelatorio = _dbContext.GroupsReports;

            return grupoRelatorio.ToList();
        }
    }
}
