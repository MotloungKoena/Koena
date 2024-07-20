using Microsoft.AspNetCore.Mvc;

namespace MaLacoste.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
