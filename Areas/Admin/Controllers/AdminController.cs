using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using App.Domain.Service;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Market_Place.Areas.Admin.Controllers
{
    [Authorize("ISAdmin")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly ICustomerService _customerService;
        private readonly IBoothService _boothService;
        private readonly ISalesManService _salesManService;
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IMapper mapper, IProductService productService, ICommentService commentService, ICustomerService customerService, IBoothService boothService, ISalesManService salesManService)
        {
            _adminService = adminService;
            _mapper = mapper;
            _productService = productService;
            _commentService = commentService;
            _customerService = customerService;
            _boothService = boothService;
            _salesManService = salesManService;
        }

        public async Task<IActionResult> Dashboard(CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);

            var commentList = new List<Comment>();
            commentList =  await _commentService.GetAllNotConfirmed(cancellationToken);
            ViewBag.CommentsNotConfirmed = commentList;

            var productList = new List<Product>();
            productList = await _productService.GetNotConfirmedProducts(cancellationToken);
            ViewBag.ProductsNotConfirmed = productList;

            return View("~/Areas/Admin/Views/Admin/Dashboard.cshtml");
        }

        public async Task<IActionResult> ConfirmProduct(int productId, bool confirmed, CancellationToken cancellationToken)
        {
            var product = await _productService.GetById(productId, cancellationToken);
            await _adminService.ConfirmSalesManeProducts(product, confirmed, cancellationToken);
            return RedirectToAction("AllProducts");
        }

        public async Task<IActionResult> ConfirmComment(int commentId, bool confirmed, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var comment = await _commentService.GetById(commentId, cancellationToken);
            await _adminService.ConfirmCustomerComment(comment, confirmed, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> AllProducts(CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var list = await _productService.GetAll(cancellationToken);
            return View(list);
        }

        public async Task<IActionResult> AllCustomers(CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var list = await _customerService.GetAll(cancellationToken);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> EditCustomer(int customerId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var c = await _customerService.GetById(customerId, cancellationToken);
            return View(c);
        }

        [HttpPost]
        public async Task<IActionResult> EditCustomer(App.Domain.Core.Entities.Customer customer, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.EditCustomer(customer, cancellationToken);
            return RedirectToAction("AllCustomers");
        }

        public async Task<IActionResult> DeleteCustomer(int customerId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.DeleteCustomer(customerId, cancellationToken);
            return RedirectToAction("AllCustomers");
        }

        public async Task<IActionResult> AllBooth(CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var list = await _boothService.GetAll(cancellationToken);
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> EditBooth(CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditBooth(int boothId, Booth booth, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.EditBooth(boothId, booth, cancellationToken);
            return View();
        }

        public async Task<IActionResult> DeleteBooth(int boothId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.DeleteBooth(boothId, cancellationToken);
            return RedirectToAction("AllBooth");
        }

        public async Task<IActionResult> ProductDetail(int productId, CancellationToken cancellationToken)
        {
            var productDto = _productService.MapToDto(await _productService.GetById(productId, cancellationToken), cancellationToken);
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            return View();
        }

        public async Task<IActionResult> BoothDetail(int boothId, CancellationToken cancellationToken)
        {
            var b = await _boothService.GetById(boothId, cancellationToken);
            ViewBag.BoothProducts = await _productService.GetByBoothId(boothId, cancellationToken);
            ViewBag.Discount = await _adminService.GetBoothDiscountDetails(boothId, cancellationToken);
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

        [HttpGet]
        public async Task<IActionResult> EditProduct(int productId,CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            var p = await _productService.GetById(productId, cancellationToken);
            return View(p);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(Product product, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.EditProduct(product, cancellationToken);
            return RedirectToAction("ProductDetail", new {productId = product.Id});
        }

        public async Task<IActionResult> DeleteProduct(int ProductId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _adminService.GetAdminDto(User, cancellationToken);
            await _adminService.DeleteProduct(ProductId, cancellationToken);
            return RedirectToAction("AllBooth");
        }

    }
}
