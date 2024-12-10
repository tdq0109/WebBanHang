using Microsoft.AspNetCore.Mvc;

namespace ASM_Final.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Details()
		{
			return View();
		}
	}
}
