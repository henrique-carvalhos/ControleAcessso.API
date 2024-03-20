using ControleAcessso.API.Entities;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;

namespace ControleAcessso.API.Services.Implementations
{
    public class GroupService : IGroupService
    {
        private readonly ControleAcessoDbContext _dbcontext;
        public GroupService(ControleAcessoDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Group> GetAll()
        {
            var groups = _dbcontext.Groups;

            return groups;
        }
    }
}
