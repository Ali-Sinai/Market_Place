using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        private readonly IMapper _mapper;

        public AdminController(IAdminService adminService, IMapper mapper, IProductService productService, ICommentService commentService, ICustomerService customerService, IBoothService boothService)
        {
            _adminService = adminService;
            _mapper = mapper;
            _productService = productService;
            _commentService = commentService;
            _customerService = customerService;
            _boothService = boothService;
        }

        public async Task<IActionResult> Dashboard(CancellationToken cancellationToken)
        {
            var adminUsername = User.Identity.Name;
            var list = await _adminService.GetAll(cancellationToken);
            var list2 =
                from a in list
                where a.UserName == adminUsername
                select a;
            var adminDto = _adminService.MapToDto(list2.ToList().FirstOrDefault());
            ViewBag.User = adminDto;
            var commentList = new List<Comment>();
            commentList =  await _commentService.GetAllNotConfirmed(cancellationToken);
            ViewBag.CommentsNotConfirmed = commentList;
            return View("~/Areas/Admin/Views/Admin/Dashboard.cshtml");
        }

        public async Task<IActionResult> ConfirmProductsPage(CancellationToken cancellationToken)
        {
            //var list = await _adminService.GetNotConfirmedProducts(cancellationToken);
            var list = new List<Product>
            {
                new Product {Comments = new List<Comment>(), Description = "product 1", IsConfirmed = false, IsDeleted = false},
                new Product {Comments = new List<Comment>(), Description = "product 2", IsConfirmed = false, IsDeleted = false},
                new Product {Comments = new List<Comment>(), Description = "product 3", IsConfirmed = false, IsDeleted = false},
                new Product {Comments = new List<Comment>(), Description = "product 4", IsConfirmed = false, IsDeleted = false},
                new Product {Comments = new List<Comment>(), Description = "product 5", IsConfirmed = false, IsDeleted = false},
            };
            var list2 = new List<ProductDto>();
            for (int i = 0; i < list.Count; i++)
            {
                list2[i] = _mapper.Map<ProductDto>(list[i]);
            }
            return View(list2);
        }

        public async Task<IActionResult> ConfirmProduct(int productId, bool confirmed, CancellationToken cancellationToken)
        {
            var product = await _productService.GetBy(productId, cancellationToken);
            await _adminService.ConfirmSalesManeProducts(product, confirmed, cancellationToken);
            return RedirectToAction("ConfirmProductsPage");
        }

        public async Task<IActionResult> ConfirmComment(int commentId, bool Confirmed, CancellationToken cancellationToken)
        {
            var comment = await _commentService.GetById(commentId, cancellationToken);
            await _adminService.ConfirmCustomerComment(comment, Confirmed, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> AllCustomers(CancellationToken cancellationToken)
        {
            var list = await _customerService.GetAll(cancellationToken);
            return View(list);
        }

        [HttpGet]
        public IActionResult EditCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditCustomer(int customerId, Customer customer, CancellationToken cancellationToken)
        {
            _adminService.EditCustomer(customerId, customer, cancellationToken);
            return View();
        }

        public IActionResult DeleteCustomer(int customerId, CancellationToken cancellationToken)
        {
            _adminService.DeleteCustomer(customerId, cancellationToken);
            return RedirectToAction("AllCustomers");
        }

        public async Task<IActionResult> AllBooth(CancellationToken cancellationToken)
        {
            var list = await _boothService.GetAll(cancellationToken);
            return View(list);
        }

        [HttpGet]
        public IActionResult EditBooth()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditBooth(int boothId, Booth booth, CancellationToken cancellationToken)
        {
            _adminService.EditBooth(boothId, booth, cancellationToken);
            return View();
        }

        public IActionResult DeleteBooth(int boothId, CancellationToken cancellationToken)
        {
            _adminService.DeleteBooth(boothId, cancellationToken);
            return View();
        }

        public IActionResult EditProduct(Product product, CancellationToken cancellationToken)
        {
            _adminService.EditProduct(product, cancellationToken);
            return View();
        }

        public IActionResult DeleteProduct(int ProductId, CancellationToken cancellationToken)
        {
            _adminService.DeleteProduct(ProductId, cancellationToken);
            return View();
        }

        public IActionResult GetBoothDiscountDetails(int BoothId, CancellationToken cancellationToken)
        {
            _adminService.GetBoothDiscountDetails(BoothId, cancellationToken);
            return View();
        }

    }
}
