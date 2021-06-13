using Microsoft.EntityFrameworkCore;
using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.Sport;
using Recreationals.Dal.Context;
using Recreationals.Dal.Entities;
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

        public async Task<SportCreateRes> CreateAsync(SportCreateReq req)
        {
            Sport sport = new Sport
            {
                Name = req.Name,
                PhotoUrl = req.PhotoUrl
            };

            _dbContext.Sports.Add(sport);
            await _dbContext.SaveChangesAsync();

            return new SportCreateRes { Id = sport.Id };
        }

        public Task DeleteAsync(SportDeleteReq req)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SportGetListResItem>> GetListAsync(SportGetListReq req)
        {
            IEnumerable<SportGetListResItem> res = await _dbContext.Sports
                .Select(s => new SportGetListResItem
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToListAsync();

            return res;
        }

        public async Task<SportGetUpdateRes> GetUpdateAsync(SportGetUpdateReq req)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SportUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}
