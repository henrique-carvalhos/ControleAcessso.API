using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class GrupoRelatorioService : IGrupoRelatorioService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public GrupoRelatorioService(ControleAcessoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GroupReport> GetAll()
        {
            var grupoRelatorio = _dbContext.GruposRelatorios;

            return grupoRelatorio.ToList();
        }
    }
}
