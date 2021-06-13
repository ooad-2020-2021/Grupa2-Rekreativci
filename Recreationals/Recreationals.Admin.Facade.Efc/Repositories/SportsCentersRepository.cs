using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.SportsCenter;
using Recreationals.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreationals.Admin.Facade.Efc.Repositories
{
    public class SportsCentersRepository : ISportsCentersRepository
    {
        private ApplicationDbContext _dbContext;

        public SportsCentersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<SportsCenterCreateRes> CreateAsync(SportsCenterCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SportsCenterDeleteReq req)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SportsCenterGetListResItem>> GetListAsync(SportsCenterGetListReq req)
        {
            throw new NotImplementedException();
        }

        public Task<SportsCenterGetUpdateRes> GetUpdateAsync(SportsCenterGetUpdateReq req)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SportsCenterUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}
