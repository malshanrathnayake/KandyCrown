using Microsoft.AspNetCore.Mvc;

namespace KandyCrown.Web.Controllers
{
    public class PublicLayoutController : Controller
    {
        public async Task<IActionResult> Header()
        {
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            return View();
        }

        public async Task<IActionResult> Navigation()
        {
            return View();
        }
    }
}
