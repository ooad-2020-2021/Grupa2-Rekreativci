using Recreationals.Public.Models.Term;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Repositories
{
    public interface ITermsRepository
    {
        Task<TermTryCreateRes> TryCreateAsync(TermTryCreateReq req);
    }
}
