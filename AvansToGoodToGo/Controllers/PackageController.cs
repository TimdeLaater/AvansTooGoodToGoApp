using DomainModel.Models;
using DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace AvansTooGoodToGo.Controllers
{
    
    public class PackageController : Controller
    {
        private readonly IPackageRepo _packageRepo;
        private readonly ILogger<PackageController> _logger;
        public PackageController(ILogger<PackageController> logger, IPackageRepo packageRepo)
        {
            _packageRepo = packageRepo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var packages = _packageRepo.GetAll();
            return View(packages);
        }

    }
}
