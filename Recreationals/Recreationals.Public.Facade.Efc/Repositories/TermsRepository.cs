using Microsoft.EntityFrameworkCore;
using Recreationals.Dal.Context;
using Recreationals.Dal.Entities;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Term;
using System.Linq;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Efc.Repositories
{
    public class TermsRepository : ITermsRepository
    {
        private ApplicationDbContext _dbContext;

        public TermsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TermTryCreateRes> TryCreateAsync(TermTryCreateReq req)
        {
            #region Validation of overlapping

            bool overlappingTermExists = await _dbContext.Terms
                .Where(t => t.FieldId == req.FieldId)
                .Where(t => t.StartTime < req.EndTime && req.StartTime < t.EndTime)
                .AnyAsync();

            #endregion

            Term term = new Term
            {
                FieldId = req.FieldId.Value,
                StartTime = req.StartTime,
                EndTime = req.EndTime,
            };

            _dbContext.Terms.Add(term);
            await _dbContext.SaveChangesAsync();

            return new TermTryCreateRes { Id = term.Id };
        }
    }
}
