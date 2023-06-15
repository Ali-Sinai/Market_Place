using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Market_Place.Areas.SalesMan.Controllers
{
    [Authorize("ISSalesMan")]
    [Area("SalesMan")]
    public class SalesManController : Controller
    {
        private readonly ISalesManService _salesManService;
        private readonly IProductService _productService;
        private readonly IBidService _bidService;

        public SalesManController(ISalesManService salesManService, IBidService bidService, IProductService productService)
        {
            _salesManService = salesManService;
            _bidService = bidService;
            _productService = productService;
        }

        public async Task<IActionResult> Dashboard(CancellationToken cancellationToken)
        {
            ViewBag.User = await _salesManService.GetSalesManDto(User, cancellationToken);
            ViewBag.Bids = await _salesManService.GetBidsList(User, cancellationToken);
            return View();
        }

        [HttpGet]
        public IActionResult CreateBid()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBid(BidDto dto, CancellationToken cancellationToken)
        {
            var bid = _bidService.MapToEntity(dto);
            await _bidService.Create(bid, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<List<Bid>> GetAll(CancellationToken cancellationToken)
        {
            return await _bidService.GetAll(cancellationToken);
        }

        public async Task<Product> GetBidsProduct(int bidId, CancellationToken cancellationToken)
        {
            var b = await _bidService.GetBy(bidId, cancellationToken);
            var p = await _productService.GetBy(b.ProductId, cancellationToken);
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
            return View(money);
        }

        public async Task<IActionResult> DeActiveProduct(int bidId, CancellationToken cancellationToken)
        {
            await _bidService.DeActiveProduct(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> GetHighestOffer(int bidId, int offer, CancellationToken cancellationToken)
        {
            await _bidService.GetHighestOffer(bidId, offer, cancellationToken);
            var bidDto = _bidService.MapToDto(await _bidService.GetBy(bidId, cancellationToken));
            return RedirectToAction("BidDetails", new {bidDto});
        }

    }
}
