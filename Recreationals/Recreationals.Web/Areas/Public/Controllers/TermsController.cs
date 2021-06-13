using Microsoft.AspNetCore.Mvc;
using Recreationals.Public.Facade.Repositories;
using Recreationals.Public.Models.Term;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recreationals.Web.Areas.Public.Controllers
{
    public class TermsController : Controller
    {
        private ITermsRepository _terms;

        public TermsController(ITermsRepository terms)
        {
            _terms = terms;
        }

        [HttpGet]
        public IActionResult TryCreate(int id)
        {
            TermTryCreateReq req = new TermTryCreateReq { FieldId = id };

            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> TryCreate([FromForm] TermTryCreateReq req)
        {
            TermTryCreateRes res = await _terms.TryCreateAsync(req);

            return Redirect("~/");
        }
    }
}
