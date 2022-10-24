using Microsoft.AspNetCore.Mvc;

namespace AvansTooGoodToGo.Controllers
{
    public class PackageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
