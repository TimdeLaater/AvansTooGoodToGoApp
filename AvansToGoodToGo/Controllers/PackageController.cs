using AvansTooGoodToGo.ViewModels;
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
            ViewBag.Products = _productRepo.GetAll();
            
            //TODO: Send The canteen to the form
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPackageAsync(CreatePackageViewModel packageViewModel)
        {
            if (ModelState.IsValid) {
                Package newPackage = new Package(
                packageViewModel.Name,
                packageViewModel.Alcohol,
                packageViewModel.Price,
                packageViewModel.orderPickup,
                false,
                packageViewModel.MealType
                );
                var packageId = _packageRepo.CreateAndGet(newPackage);
                await CreatePackageProducts(packageViewModel, newPackage, packageId);




                return RedirectToAction("Index");
            }
            return View(packageViewModel);

            
        }

        public async Task CreatePackageProducts(CreatePackageViewModel packageViewModel, Package package, int id)
        {
            package.Package_Product = new List<Package_Product>();
            foreach(int productId in packageViewModel.ProductIds)
            {
               var product = _productRepo.GetbyId(productId);
                var packageProduct = new Package_Product(productId, product, id);
                package.Package_Product.Add(packageProduct);

            }
            _packageRepo.Update(package);
        }



    }
}
