using Microsoft.AspNetCore.Mvc;
using Recreationals.Admin.Facade.Repositories;
using Recreationals.Admin.Models.Sport;
using Recreationals.Admin.Models.SportsCenter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Web.Areas.Admin.Controllers
{
    public class SportsCentersController : Controller
    {
        private ISportsCentersRepository _sportsCenters;
        private ISportsRepository _sports;

        public SportsCentersController(ISportsCentersRepository sportsCenters,
            ISportsRepository sports)
        {
            _sportsCenters = sportsCenters;
            _sports = sports;
        }

        [HttpGet]
        public async Task<IActionResult> List(SportsCenterGetListReq req)
        {
            IEnumerable<SportsCenterGetListResItem> res = await _sportsCenters.GetListAsync(req);

            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SportsCenterCreateReq req = new SportsCenterCreateReq();

            IEnumerable<SportGetListResItem> sports = await _sports.GetListAsync(new SportGetListReq{ });

            req.AvailableSports = new List<System.Web.Mvc.SelectListItem>();

            foreach (SportGetListResItem sport in sports)
            {
                req.AvailableSports.Add(new System.Web.Mvc.SelectListItem { Text = sport.Name, Value = sport.Name });
            }

            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] SportsCenterCreateReq req)
        {
            SportsCenterCreateRes res = await _sportsCenters.CreateAsync(req);

            return RedirectToAction("List");
        }
    }
}
