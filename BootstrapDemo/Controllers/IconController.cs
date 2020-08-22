using Microsoft.AspNetCore.Mvc;
using BootstrapDemo.Services;
using System.Collections.Generic;

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
            var iconDictionary = new Dictionary<string, HashSet<string>>() {
                { "fas", FontAwesomeIconScanner.SolidIcons },
                { "far", FontAwesomeIconScanner.RegularIcons },
                { "fab", FontAwesomeIconScanner.BrandIcons }
            };
            return View(iconDictionary);
        }
    }
}
