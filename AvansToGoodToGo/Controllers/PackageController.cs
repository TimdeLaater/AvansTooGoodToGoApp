using DomainModel.Models;
using DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace AvansTooGoodToGo.Controllers
{
    
    public class PackageController : Controller
    {
        private readonly IPackageRepo _packageRepo;
        private readonly ILogger<PackageController> _logger;
        private readonly IProductRepo _productRepo;
        public PackageController(ILogger<PackageController> logger, IPackageRepo packageRepo, IProductRepo productRepo)
        {
            _packageRepo = packageRepo;
            _logger = logger;
            _productRepo = productRepo;
        }
        public IActionResult Index()
        {
            var packages = _packageRepo.GetAll();
            return View(packages);
        }
        [HttpGet]
        public IActionResult AddPackage()
        {
            var products = _productRepo.GetAll();
            ViewBag.data = products;
            
            return View();
        }
        [HttpPost]
        public IActionResult AddPackage(Package Package)
        {
            
            return View("index");
        }

    }
}
