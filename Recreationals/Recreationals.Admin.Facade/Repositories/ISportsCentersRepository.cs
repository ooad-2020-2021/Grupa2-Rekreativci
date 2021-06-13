using Recreationals.Admin.Models.SportsCenter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Admin.Facade.Repositories
{
    public interface ISportsCentersRepository
    {
        Task<SportsCenterCreateRes> CreateAsync(SportsCenterCreateReq req);
        Task DeleteAsync(SportsCenterDeleteReq req);
        Task<IEnumerable<SportsCenterGetListResItem>> GetListAsync(SportsCenterGetListReq req);
        Task<SportsCenterGetUpdateRes> GetUpdateAsync(SportsCenterGetUpdateReq req);
        Task UpdateAsync(SportsCenterUpdateReq req);
    }
}
