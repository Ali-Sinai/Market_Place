using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using App.Domain.Core.Contracts.Repository;

namespace Market_Place.Areas.SalesMan.Controllers
{
    [Authorize("ISSalesMan")]
    [Area("SalesMan")]
    public class SalesManController : Controller
    {
        private readonly ISalesManService _salesManService;
        private readonly IProductService _productService;
        private readonly IBidService _bidService;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IBoothService _boothService;

        public SalesManController(ISalesManService salesManService, IBidService bidService, IProductService productService, ISubCategoryRepository subCategoryRepository, IBoothService boothService)
        {
            _salesManService = salesManService;
            _bidService = bidService;
            _productService = productService;
            _subCategoryRepository = subCategoryRepository;
            _boothService = boothService;
        }

        public async Task<IActionResult> Dashboard(CancellationToken cancellationToken)
        {
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            ViewBag.Bids = await _salesManService.GetBidsList(ViewBag.User, cancellationToken);
            ViewBag.Products = await _boothService.GetAllProducts(ViewBag.User.BoothId, cancellationToken);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile(int Id, CancellationToken cancellationToken)
        {
            var salesman = await _salesManService.GetBy(Id, cancellationToken);
            ViewBag.User = salesman;
            return View(salesman);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(App.Domain.Core.Entities.SalesMan salesMan, CancellationToken cancellationToken)
        {
            await _salesManService.Update(salesMan, cancellationToken);
            ViewBag.User = salesMan;
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public async Task<IActionResult> CreateBid(CancellationToken cancellationToken)
        {
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBid(BidDto dto, CancellationToken cancellationToken)
        {
            var bid = _bidService.MapToEntity(dto);
            await _bidService.Create(bid, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> ProductDetail(int productId, CancellationToken cancellationToken)
        {
            var productDto = _productService.MapToDto(await _productService.GetById(productId, cancellationToken), cancellationToken);
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            return View(productDto);
        }

        [HttpGet]
        public async Task<IActionResult> EditProduct(int productId, CancellationToken cancellationToken)
        {
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            var product = await _productService.GetById(productId, cancellationToken);
            ViewBag.SubCategories = await _subCategoryRepository.GetAll(cancellationToken);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(Product product, CancellationToken cancellationToken)
        {
            await _productService.Update(product, cancellationToken);
            return RedirectToAction("ProductDetail", new { productId = product.Id });
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct(CancellationToken cancellationToken)
        {
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            ViewBag.SubCategories = await _subCategoryRepository.GetAll(cancellationToken);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product, CancellationToken cancellationToken)
        {
            await _productService.Create(product, cancellationToken);
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> DeleteProduct(int productId, CancellationToken cancellationToken)
        {
            await _productService.Delete(productId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<List<Bid>> GetAll(CancellationToken cancellationToken)
        {
            return await _bidService.GetAll(cancellationToken);
        }

        public async Task<Product> GetBidsProduct(int bidId, CancellationToken cancellationToken)
        {
            var b = await _bidService.GetBy(bidId, cancellationToken);
            var p = await _productService.GetById(b.ProductId, cancellationToken);
            return p;
        }

        public async Task<IActionResult> OpenBid(int bidId, CancellationToken cancellationToken)
        {
            await _bidService.OpenBid(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> CloseBid(int bidId, CancellationToken cancellationToken)
        {
            await _bidService.CloseBid(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> BidDetails(int bidId, CancellationToken cancellationToken)
        {
            var bidDto = _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken));
            //var bidDto = !(TempData["BidDto"] is BidDto) ? _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken)) : TempData["BidDto"] as BidDto;
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            return View(bidDto);
        }

        //public IActionResult GetFee(int bidId, int customerId, CancellationToken cancellationToken)
        //{
        // code to payment page
        //}

        // do not belong here
        //public async Task<IActionResult> GetFee(int bidId, int customerId, CancellationToken cancellationToken)
        //{
        //    await _bidService.GetFee(bidId, customerId, cancellationToken);
        //    return View();
        //}

        public async Task<IActionResult> PayWage(int bidId, int myId, CancellationToken cancellationToken)
        {
            var bid = await _bidService.GetBy(bidId, cancellationToken);
            var money = await _salesManService.PayWage(myId, bid.HighestPrice, cancellationToken);
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            return View(money);
        }

        public async Task<IActionResult> DeActiveProduct(int bidId, CancellationToken cancellationToken)
        {
            await _bidService.DeActiveProduct(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }
    }
}
