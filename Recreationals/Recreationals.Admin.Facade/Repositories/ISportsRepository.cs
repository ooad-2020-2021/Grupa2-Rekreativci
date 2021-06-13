using Recreationals.Admin.Models.Sport;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Admin.Facade.Repositories
{
    public interface ISportsRepository
    {
        Task<SportCreateRes> CreateAsync(SportCreateReq req);
        Task DeleteAsync(SportDeleteReq req);
        Task<IEnumerable<SportGetListResItem>> GetListAsync(SportGetListReq req);
        Task<SportGetUpdateRes> GetUpdateAsync(SportGetUpdateReq req);
        Task UpdateAsync(SportUpdateReq req);
    }
}
