using Recreationals.Public.Models.Field;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Public.Facade.Repositories
{
    public interface IFieldsRepository
    {
        Task<FieldGetDetailsRes> GetDetailsAsync(FieldGetDetailsReq req);
        Task<IEnumerable<FieldGetListResItem>> GetListAsync(FieldGetListReq req);
    }
}
