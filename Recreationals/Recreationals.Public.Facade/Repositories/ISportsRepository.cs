using Recreationals.Public.Models.Sport;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Repositories
{
    public interface ISportsRepository
    {
        Task<IEnumerable<SportGetListResItem>> GetListAsync();
    }
}
