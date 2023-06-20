using Microsoft.AspNetCore.Mvc;

namespace NgoPhamQuangThai.Controllers
{
	public class ListingController : Controller
	{
		public IActionResult grid()
		{
			return View();
		}
		public IActionResult large()
		{
			return View();
		}
	}
}
