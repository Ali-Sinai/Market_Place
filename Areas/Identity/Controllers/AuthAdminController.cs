using Market_Place.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using AutoMapper;

namespace Market_Place.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AuthAdminController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;

        public AuthAdminController(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, IMapper mapper, IAdminService adminService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _adminService = adminService;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            //return RedirectToAction("Login", "Auth");
            return View("~/Areas/Identity/Views/Auth/LoginAdmin.cshtml");
            //return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.UserName, viewModel.Password, viewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new {Area = ""});
                }

                ModelState.AddModelError("", "ورود موفقیت امیز نبود");
            }

            return View("~/Areas/Identity/Views/Auth/LoginAdmin.cshtml", viewModel);
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Areas/Identity/Views/Auth/RegisterAdmin.cshtml");
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser<int> { UserName = viewModel.UserName, Email = viewModel.Email };
                var result = await _userManager.CreateAsync(user, viewModel.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    var claim = new Claim("AuthorizedRole", "ISAdmin");
                    await _userManager.AddClaimAsync(user, claim);
                    await _adminService.AddAdminToDb(_adminService.MapToEntity(user), CancellationToken.None);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home", new {Area = ""});
                }

                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError("", i.Description);
                }
            }
            return View("~/Areas/Identity/Views/Auth/RegisterAdmin.cshtml", viewModel);
        }
    }
}
