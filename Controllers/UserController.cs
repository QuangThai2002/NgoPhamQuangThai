using Microsoft.AspNetCore.Mvc;

namespace NgoPhamQuangThai.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
	}
}
