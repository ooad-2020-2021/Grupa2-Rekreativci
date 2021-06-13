using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Sport;
using Recreationals.Web.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Recreationals.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ISportsRepository _sports;

        public HomeController(
            ILogger<HomeController> logger,
            ISportsRepository sports)
        {
            _logger = logger;
            _sports = sports;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<SportGetListResItem> res = await _sports.GetListAsync();

            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
