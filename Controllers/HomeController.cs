using App.Domain.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.Extensions.Caching.Memory;
using App.Domain.Service;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using App.Domain.Core.DTOs;

namespace Market_Place.Controllers
{
	public class HomeController : Controller
	{
        #region DI

        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memorychache;
        private readonly IBoothService _boothService;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IAdminService _adminService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductService _productService;
        private readonly IBidService _bidService;
        private readonly ICustomerService _customerService;
        private readonly ICommentRepository _commentRepository;
        private readonly ISalesManService _salesManService;
        private readonly SignInManager<IdentityUser<int>> SignInManager;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memorychache, IBoothService boothService, ISubCategoryRepository subCategoryRepository, IAdminService adminService, ICategoryRepository categoryRepository, IProductService productService, IBidService bidService, ICustomerService customerService, SignInManager<IdentityUser<int>> signInManager, ICommentRepository commentRepository, ISalesManService salesManService)
        {
            _memorychache = memorychache;
            _logger = logger;
            _boothService = boothService;
            _subCategoryRepository = subCategoryRepository;
            _adminService = adminService;
            _categoryRepository = categoryRepository;
            _productService = productService;
            _bidService = bidService;
            _customerService = customerService;
            SignInManager = signInManager;
            _commentRepository = commentRepository;
            _salesManService = salesManService;
        }

        #endregion

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
		{
			if (_memorychache.Get("Admins") == null)
			{
				MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions();
				//cacheOptions.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(20);
				cacheOptions.SlidingExpiration = TimeSpan.FromSeconds(8);
                var value =  await _adminService.GetAll(cancellationToken);
				_memorychache.Set("Admins", value);
			}

            ViewBag.PartofCategories = await _categoryRepository.GetPartof(6, cancellationToken);
            ViewBag.PartofBooths = await _boothService.GetPartof(6,cancellationToken);
            ViewBag.RandomBids = await _bidService.GetRandom(cancellationToken);

            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }

            return View();
		}

        public async Task<IActionResult> BoothDetail(int boothId, CancellationToken cancellationToken)
        {
            var b = await _boothService.GetById(boothId, cancellationToken);
            ViewBag.BoothProducts = await _productService.GetByBoothId(boothId, cancellationToken);
            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }


            return View(b);
        }

        public async Task<IActionResult> BidDetails(int bidId, CancellationToken cancellationToken)
        {
            var b = _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken));
            ViewBag.Comments = await _commentRepository.GetAllForProduct(b.ProductId, cancellationToken);
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }
            return View(b);
        }

        public async Task<IActionResult> AllBooth(CancellationToken cancellationToken)
        {
            ViewBag.Booths = await _boothService.GetAll(cancellationToken);
            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }
            return View();

        }

        public async Task<IActionResult> ProductDetail(int productId, CancellationToken cancellationToken)
        {
            var p = _productService.MapToDto(await _productService.GetById(productId, cancellationToken), cancellationToken);
            ViewBag.Comments = await _commentRepository.GetAllForProduct(productId, cancellationToken);
            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }

            return View(p);
        }

        public async Task<IActionResult> CategoryProducts(int categoryId, CancellationToken cancellationToken)
        {
            var list = await _productService.GetByCategory(categoryId, cancellationToken);
            List<string> userClaims = new List<string>();
            var claims = User.Claims;
            if (claims != null)
            {
                foreach (var claim in claims)
                {
                    userClaims.Add(claim.Value);
                }
                ViewBag.UserClaims = userClaims;
            }
            else
            {
                ViewBag.UserClaims = new List<string>();
            }

            if (ViewBag.UserClaims.Count != 0)
            {
                ViewBag.User = ViewBag.UserClaims[4] == "ISCustomer" ? await _customerService.GetCustomerDto(User, cancellationToken) :
                    (ViewBag.UserClaims[4] == "ISAdmin" ? await _adminService.GetAdminDto(User, cancellationToken) :
                        await _salesManService.GetSalesManDto(User, cancellationToken));
            }
            return View(list);
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}