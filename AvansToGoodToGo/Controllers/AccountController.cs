using AvansToGoodToGo.Models;
using AvansTooGoodToGo.ViewModels;
using DomainModel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AvansTooGoodToGo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByNameAsync(vm.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Incorrect username or password or account is locked");
                return View();
            }

            var signinResult = await _signInManager.PasswordSignInAsync(user, vm.Password, true, false);

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect username or password or account is locked");
                return View();
            }

            return RedirectToAction("index", "home");

        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult RegisterStudent()
        {
            return View(new RegisterStudentViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> RegisterStudent(RegisterStudentViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            
            return View();
        }
        public IActionResult RegisterCanteenWorker()
        {
            return View();
        }
    }
}
