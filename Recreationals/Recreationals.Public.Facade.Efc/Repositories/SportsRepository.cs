using Microsoft.EntityFrameworkCore;
using Recreationals.Dal.Context;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Sport;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Efc.Repositories
{
    public class SportsRepository : ISportsRepository
    {
        private ApplicationDbContext _dbContext;

        public SportsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SportGetListResItem>> GetListAsync()
        {
            IEnumerable<SportGetListResItem> res = await _dbContext.Sports
                .Select(s => new SportGetListResItem
                {
                    Id = s.Id,
                    Name = s.Name,
                    PhotoUrl = s.PhotoUrl
                })
                .ToListAsync();

            return res;
        }
    }
}
