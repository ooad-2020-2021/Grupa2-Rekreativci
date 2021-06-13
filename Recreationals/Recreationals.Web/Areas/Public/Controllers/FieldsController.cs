using Microsoft.AspNetCore.Mvc;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Field;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Web.Areas.Public.Controllers
{
    public class FieldsController : Controller
    {
        private IFieldsRepository _fields;

        public FieldsController(IFieldsRepository fields)
        {
            _fields = fields;
        }

        [HttpGet]
        public async Task<IActionResult> List(int id)
        {
            IEnumerable<FieldGetListResItem> res = await _fields.GetListAsync(new FieldGetListReq { SportId = id });

            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            FieldGetDetailsRes res = await _fields.GetDetailsAsync(new FieldGetDetailsReq { Id = id });

            return View(res);
        }
    }
}
