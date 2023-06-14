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
            var salesManUsername = User.Identity.Name;
            var list = await _salesManService.GetAll(cancellationToken);
            var list2 =
                from a in list
                where a.UserName == salesManUsername
                select a;
            var salesManDto = _salesManService.MapToDto(list2.ToList().FirstOrDefault());
            //ViewBag.SalesManDto = salesManDto;
            var list3 = await _bidService.GetAll(cancellationToken);
            var x =
                from bid in list3
                select bid;
            var Bids = x.ToList()==null ? new List<Bid>() : x.ToList();
            ViewBag.Bids = Bids;
            return View(salesManDto);
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

        public IActionResult OpenBid(int bidId, CancellationToken cancellationToken)
        {
            _bidService.OpenBid(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public IActionResult CloseBid(int bidId, CancellationToken cancellationToken)
        {
            _bidService.CloseBid(bidId, cancellationToken);
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> BidDetails(int bidId, CancellationToken cancellationToken)
        {
            var bid = await _bidService.GetBy(bidId, cancellationToken);
            var bidDto = _bidService.MapToDto(bid);
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
            return RedirectToAction("BidDetails");
        }

    }
}
