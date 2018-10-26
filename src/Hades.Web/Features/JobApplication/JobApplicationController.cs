using Microsoft.AspNetCore.Mvc;

namespace Hades.Web.Features.JobApplication
{
    public class JobApplicationController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
