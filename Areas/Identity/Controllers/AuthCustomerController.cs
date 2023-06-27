using App.Domain.Core.DTOs;
using Market_Place.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using App.Domain.Core.Contracts.Service;
using AutoMapper;

namespace Market_Place.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AuthCustomerController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public AuthCustomerController(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, IMapper mapper, ICustomerService customerService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _customerService = customerService;
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
                    return RedirectToAction("Index", "Home", new {Area = ""});
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
        public async Task<IActionResult> Register(RegisterViewModel viewModel, CancellationToken cancellationToken)
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
                    await _customerService.AddToDb(_customerService.MapToEntity(user), cancellationToken);
                    return RedirectToAction("Index", "Home", new {Area = ""});
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
