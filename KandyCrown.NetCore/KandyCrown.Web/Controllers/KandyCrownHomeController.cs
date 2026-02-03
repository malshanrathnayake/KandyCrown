using Microsoft.AspNetCore.Mvc;

namespace KandyCrown.Web.Controllers
{
    public class KandyCrownHomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Hero()
        {
            return View();
        }

        public async Task<IActionResult> Footer()
        {
            return View();
        }
    }
}
