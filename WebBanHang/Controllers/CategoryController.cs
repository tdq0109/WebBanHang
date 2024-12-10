using Microsoft.AspNetCore.Mvc;

namespace ASM_Final.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
