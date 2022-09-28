using DomainModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvansToGoodToGo.Controllers
{
    public class CanteenController : Controller
    {
        private readonly ILogger<CanteenController> _logger;

        public CanteenController (ILogger<CanteenController> logger)
        {
            _logger = logger;
        }
        // GET: CanteenController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddProduct(Product product)
        {
            _logger.LogInformation(product.ToString());

            return View();
        }

        // GET: CanteenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CanteenController/Create
        public ActionResult Create()
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

        // POST: CanteenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: CanteenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CanteenController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
