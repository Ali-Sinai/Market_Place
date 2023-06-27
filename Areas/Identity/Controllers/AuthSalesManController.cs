using System.Security.Claims;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using AutoMapper;
using Market_Place.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Market_Place.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AuthSalesManController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly ISalesManService _salesManService;
        private readonly IMapper _mapper;

        public AuthSalesManController(UserManager<IdentityUser<int>> userManager, SignInManager<IdentityUser<int>> signInManager, IMapper mapper, ISalesManService salesManService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _salesManService = salesManService;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            //return RedirectToAction("Login", "Auth");
            return View("~/Areas/Identity/Views/Auth/LoginSalesMan.cshtml");
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
                    return RedirectToAction("Index", "Home", new {Area = ""} );
                }

                ModelState.AddModelError("", "ورود موفقیت امیز نبود");
            }

            return View("~/Areas/Identity/Views/Auth/LoginSalesMan.cshtml", viewModel);
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Areas/Identity/Views/Auth/RegisterSalesMan.cshtml");
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
                    var claim = new Claim("AuthorizedRole", "ISSalesMan");
                    await _userManager.AddClaimAsync(user, claim);
                    await _salesManService.AddToDb(_salesManService.MapToEntity(user), cancellationToken);
                    //var salesMan = _mapper.Map<SalesManDto>(user);
                    return RedirectToAction("Dashboard", "SalesMan",new {Area = "SalesMan" });
                }

                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError("", i.Description);
                }
            }
            return View("~/Areas/Identity/Views/Auth/RegisterSalesMan.cshtml", viewModel);
        }
    }
}
