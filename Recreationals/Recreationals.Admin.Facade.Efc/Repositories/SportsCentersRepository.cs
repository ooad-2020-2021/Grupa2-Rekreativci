using Microsoft.EntityFrameworkCore;
using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.Sport;
using Recreationals.Admin.Models.SportsCenter;
using Recreationals.Dal.Context;
using Recreationals.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recreationals.Admin.Facade.Efc.Repositories
{
    public class SportsCentersRepository : ISportsCentersRepository
    {
        private ApplicationDbContext _dbContext;
        private ISportsRepository _sports;

        public SportsCentersRepository(ApplicationDbContext dbContext, ISportsRepository sports)
        {
            _dbContext = dbContext;
            _sports = sports;
        }

        public async Task<SportsCenterCreateRes> CreateAsync(SportsCenterCreateReq req)
        {
            SportsCenter sportsCenter = new SportsCenter
            {
                Name = req.Name,
                PhotoUrl = req.PhotoUrl,
                Description = req.Description,

            };

            _dbContext.SportsCenters.Add(sportsCenter);
            await _dbContext.SaveChangesAsync();

            #region Handle Fields

            IEnumerable<SportGetListResItem> sports = await _sports.GetListAsync(new SportGetListReq { });

            foreach (string sport in req.SelectedSports)
            {
                int sportId = sports
                    .Where(s => s.Name == sport)
                    .Select(s => s.Id)
                    .FirstOrDefault();

                Field field = new Field
                {
                    SportId = sportId,
                    SportsCenterId = sportsCenter.Id
                };

                _dbContext.Fields.Add(field);
            }

            await _dbContext.SaveChangesAsync();


            #endregion

            return new SportsCenterCreateRes { Id = sportsCenter.Id };
        }

        public Task DeleteAsync(SportsCenterDeleteReq req)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SportsCenterGetListResItem>> GetListAsync(SportsCenterGetListReq req)
        {
            IEnumerable<SportsCenterGetListResItem> res = await _dbContext.SportsCenters
                .Select(s => new SportsCenterGetListResItem
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToListAsync();

            return res;
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
