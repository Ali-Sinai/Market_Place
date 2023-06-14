using App.Domain.Core.DTOs;
using Market_Place.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using AutoMapper;

namespace Market_Place.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AuthCustomerController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly IMapper _mapper;

        public AuthCustomerController(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            //return RedirectToAction("Login", "Auth");
            return View("~/Areas/Identity/Views/Auth/LoginCustomer.cshtml");
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
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "ورود موفقیت امیز نبود");
            }

            return View("~/Areas/Identity/Views/Auth/LoginCustomer.cshtml", viewModel);
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Areas/Identity/Views/Auth/RegisterCustomer.cshtml");
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
                    var claim = new Claim("AuthorizedRole", "ISCustomer");
                    await _userManager.AddClaimAsync(user, claim);
                    var customer = _mapper.Map<CustomerDto>(user);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError("", i.Description);
                }
            }
            return View("~/Areas/Identity/Views/Auth/RegisterCustomer.cshtml", viewModel);
        }
    }
}
