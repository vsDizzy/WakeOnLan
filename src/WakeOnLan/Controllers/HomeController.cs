using Microsoft.AspNet.Mvc;

namespace WakeOnLan.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}