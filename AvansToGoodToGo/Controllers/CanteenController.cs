using DomainModel.Models;
using DomainServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvansToGoodToGo.Controllers
{
    public class CanteenController : Controller
    {
        private readonly ILogger<CanteenController> _logger;
        private readonly IProductRepo _productRepo;
        public CanteenController (ILogger<CanteenController> logger, IProductRepo productRepo)
        {
            _logger = logger;
            _productRepo = productRepo;
        }
        // GET: CanteenController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(_productRepo.GetAll().ToList());
        }
        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProductAsync(Product product)
        {
            if(ModelState.IsValid)
            {
                if (_productRepo.GetAll().Exists(t => t?.Name == product.Name))
                {
                    ModelState.AddModelError(String.Empty, "De dit product bestaat al.");
                    return View();
                }

                _productRepo.Create(product);
               
                return View("Products");
            }
            return  View(product);
        }

        // GET: CanteenController/Details/5





        // GET: CanteenController/Edit/5
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = _productRepo.GetbyId(id);
            if(product == null)
            {
                return NotFound();
            }
            
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product, int id)
        {
            return View("Products");
        }
        public IActionResult ProductDeleted(int id)
        {
            if (ModelState.IsValid)
            {
                _productRepo.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }




    }
}
