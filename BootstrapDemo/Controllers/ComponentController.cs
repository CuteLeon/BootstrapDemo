using Microsoft.AspNetCore.Mvc;

namespace BootstrapDemo.Controllers
{
    public class ComponentController : Controller
    {
        public IActionResult Alert()
        {
            return View();
        }

        public IActionResult Badge()
        {
            return View();
        }
    }
}
