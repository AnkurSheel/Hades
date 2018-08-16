using Microsoft.AspNetCore.Mvc;

namespace Hades.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
