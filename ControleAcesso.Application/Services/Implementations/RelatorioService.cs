using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class RelatorioService : IRelatorioService
    {
        private readonly ControleAcessoDbContext _dbContext;
        public RelatorioService(ControleAcessoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Relatorio> GetAll()
        {
            var relatorios = _dbContext.Relatorios;

            return relatorios.ToList();
        }
    }
}
