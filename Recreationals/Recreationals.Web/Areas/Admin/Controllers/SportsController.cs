using Microsoft.AspNetCore.Mvc;
using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.Sport;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Web.Areas.Admin.Controllers
{
    public class SportsController : Controller
    {
        private ISportsRepository _sports;

        public SportsController(ISportsRepository sports)
        {
            _sports = sports;
        }

        [HttpGet]
        public async Task<IActionResult> List(SportGetListReq req)
        {
            IEnumerable<SportGetListResItem> res = await _sports.GetListAsync(req);

            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] SportCreateReq req)
        {
            SportCreateRes res = await _sports.CreateAsync(req);

            return RedirectToAction("List");
        }
    }
}
