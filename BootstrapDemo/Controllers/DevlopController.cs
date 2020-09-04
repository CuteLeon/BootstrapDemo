using Microsoft.AspNetCore.Mvc;

namespace BootstrapDemo.Controllers
{
    public class DevlopController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
