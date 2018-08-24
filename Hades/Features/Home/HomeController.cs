using Microsoft.AspNetCore.Mvc;

namespace Hades.Features.Home
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
