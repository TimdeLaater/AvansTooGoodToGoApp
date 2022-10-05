using AvansToGoodToGo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AvansTooGoodToGo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
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
    }
}
