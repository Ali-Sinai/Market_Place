using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using App.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using App.Domain.Core.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Market_Place.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerController : Controller
    {
        private readonly IBidService _bidService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public CustomerController(IBidService bidService, ICustomerService customerService, IProductService productService)
        {
            _bidService = bidService;
            _customerService = customerService;
            _productService = productService;
        }

        public async Task<IActionResult> Dashboard(CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            return View();
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            return RedirectToAction("Index", "Home", new { Area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile(int Id, CancellationToken cancellationToken)
        {
            var x = await _customerService.GetById(Id, CancellationToken.None);
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(App.Domain.Core.Entities.Customer customer, CancellationToken cancellationToken)
        {
            await _customerService.Update(customer, cancellationToken);
            ViewBag.User = customer;
            return RedirectToAction("Dashboard");
        }


        public async Task<IActionResult> GetFactor(int customerId, CancellationToken cancellationToken)
        {
            ViewBag.Products = await _customerService.GetFactor(customerId, cancellationToken);
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            return View();
        }

        public async Task<IActionResult> PurchaseHistory(int customerId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            ViewBag.Products = await _customerService.GetPurchaseHistory(customerId, cancellationToken);
            return View();
        }

        public async Task<IActionResult> AddComment(string message, int productId, int userId,
            CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            var c = new Comment { CustomerId = userId, ProductId = productId, Message = message, IsDeleted = false };
            await _customerService.AddComment(c, cancellationToken);
            return RedirectToAction("ProductDetail", "Home", new { Area = "", productId = productId });
        }

        public async Task<IActionResult> BuyInBid(int bidId, int offer, int userId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            await _bidService.BuyInBid(bidId, offer, userId, cancellationToken);
            return RedirectToAction("BidDetails", "Customer", new { bidId });
        }

        public async Task<IActionResult> CheckHasBid(int productId, CancellationToken cancellationToken)
        {
            var product = await _productService.GetById(productId, cancellationToken);
            var bid = await _bidService.GetByProductId(productId, cancellationToken);
            await _bidService.OpenBid(bid.Id, cancellationToken);
            return RedirectToAction("BidDetails", new { bidId = bid.Id });
        }

        public async Task<IActionResult> BuyProductNormal(int productId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            await _customerService.BuyNormal( ViewBag.User.Id, productId, cancellationToken);
            return RedirectToAction("Index", "Home", new {Area = ""});
        }

        public async Task<IActionResult> BidDetails(int bidId, CancellationToken cancellationToken)
        {
            var bidDto = _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken));
            //var bidDto = !(TempData["BidDto"] is BidDto) ? _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken)) : TempData["BidDto"] as BidDto;
            ViewBag.User = await _customerService.GetCustomerDto(User, cancellationToken);
            return View(bidDto);
        }

        public async Task<IActionResult> ClearFactor(int customerId, CancellationToken cancellationToken)
        {
            await _customerService.ClearFactor(customerId, cancellationToken);
            return RedirectToAction("GetFactor");
        }
    }
}
