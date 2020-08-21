using Microsoft.AspNetCore.Mvc;
using BootstrapDemo.Services;

namespace BootstrapDemo.Controllers
{
    public class IconController : Controller
    {
        private readonly IFontAwesomeIconScanner fontAwesomeIconScanner;

        public IconController(
            IFontAwesomeIconScanner fontAwesomeIconScanner)
        {
            this.fontAwesomeIconScanner = fontAwesomeIconScanner;
        }

        public IActionResult FontAwesome()
        {
            this.ViewData.Add("FAS", FontAwesomeIconScanner.SolidIcons);
            this.ViewData.Add("FAR", FontAwesomeIconScanner.RegularIcons);
            this.ViewData.Add("FAB", FontAwesomeIconScanner.BrandIcons);
            return View();
        }
    }
}
