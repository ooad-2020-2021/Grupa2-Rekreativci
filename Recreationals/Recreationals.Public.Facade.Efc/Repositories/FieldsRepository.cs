using Microsoft.EntityFrameworkCore;
using Recreationals.Dal.Context;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Field;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Efc.Repositories
{
    public class FieldsRepository : IFieldsRepository
    {
        private ApplicationDbContext _dbContext;

        public FieldsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FieldGetDetailsRes> GetDetailsAsync(FieldGetDetailsReq req)
        {
            FieldGetDetailsRes res = await _dbContext.Fields
                .Where(f => f.Id == req.Id)
                .Select(f => new FieldGetDetailsRes
                {
                    Id = f.Id,
                    SportName = f.Sport.Name,
                    SportsCenterName = f.SportsCenter.Name,
                    Terms = f.Terms
                        .Select(t => new FieldGetDetailsRes.TermDto
                        {
                            StartTime = t.StartTime,
                            EndTime = t.EndTime,
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            return res;
        }

        public async Task<IEnumerable<FieldGetListResItem>> GetListAsync(FieldGetListReq req)
        {
            IEnumerable<FieldGetListResItem> res = await _dbContext.Fields
                .Where(f => f.SportId == req.SportId)
                .Select(f => new FieldGetListResItem
                {
                    Id = f.Id,
                    SportName = f.Sport.Name,
                    SportsCenterName = f.SportsCenter.Name,
                    SportsCenterPhotoUrl = f.SportsCenter.PhotoUrl
                })
                .ToListAsync();

            return res;
        }
    }
}
