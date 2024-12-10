using Microsoft.AspNetCore.Mvc;

namespace ASM_Final.Controllers
{
    public class CartController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CheckOut()
		{
			return View("~/Views/CheckOut/Index.cshtml");
		}
	}
}
