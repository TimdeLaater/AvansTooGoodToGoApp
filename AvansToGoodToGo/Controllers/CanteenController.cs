using DomainModel.Models;
using DomainServices;
using Microsoft.AspNetCore.Authorization;
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
            return View(_productRepo.Get().ToList());
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
                if (_productRepo.Get().Exists(t => t?.Name == product.Name))
                {
                    ModelState.AddModelError(String.Empty, "De dit product bestaat al.");
                    return View();
                }

                _productRepo.Create(product);
                await Task.Delay(1000);
                return View("Products");
            }
            return View(product);
        }

        // GET: CanteenController/Details/5
        [Authorize(Policy = "CanteenWorker")]
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // POST: CanteenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CanteenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }




    }
}
