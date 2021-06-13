using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.Sport;
using Recreationals.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreationals.Admin.Facade.Efc.Repositories
{
    public class SportsRepository : ISportsRepository
    {
        private ApplicationDbContext _dbContext;

        public SportsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<SportCreateRes> CreateAsync(SportCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SportDeleteReq req)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SportGetListResItem>> GetListAsync(SportGetListReq req)
        {
            throw new NotImplementedException();
        }

        public Task<SportGetUpdateRes> GetUpdateAsync(SportGetUpdateReq req)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SportUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}
