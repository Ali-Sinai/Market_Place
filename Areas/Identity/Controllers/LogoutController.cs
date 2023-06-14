using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Market_Place.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize]
    public class LogoutController : Controller
    {
        private readonly SignInManager<IdentityUser<int>> _signInManager;

        public LogoutController(SignInManager<IdentityUser<int>> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new {Area = ""});
        }
    }
}
