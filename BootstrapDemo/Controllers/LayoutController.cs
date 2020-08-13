using Microsoft.AspNetCore.Mvc;

namespace BootstrapDemo.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Grid()
        {
            return View();
        }
    }
}
