using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service
{
    public class BidService : IBidService
    {
        private readonly IBidRepository _bidRepository;
        private readonly ISalesManService _salesManService;
        private readonly IProductRepository _productRepository;
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public BidService(IBidRepository bidRepository, ISalesManService salesManService, IProductRepository productRepository, IMapper mapper, ICustomerService customerService)
        {
            _bidRepository = bidRepository;
            _salesManService = salesManService;
            _productRepository = productRepository;
            _mapper = mapper;
            _customerService = customerService;
        }

        public async Task Create(Bid bid, CancellationToken cancellationToken)
        {
            await _bidRepository.Create(bid, cancellationToken);
            var p = await _productRepository.GetById(bid.ProductId, cancellationToken);
            p.BidId = bid.Id;
            await _productRepository.Update(p, cancellationToken);
        }

        public async Task Delete(Bid bid, CancellationToken cancellationToken)
        {
            await _bidRepository.Delete(bid, cancellationToken);
        }

        public async Task Update(Bid bid, CancellationToken cancellationToken)
        {
            await _bidRepository.Update(bid, cancellationToken);
        }

        public async Task<List<Bid>> GetAll(CancellationToken cancellationToken)
        {
            return await _bidRepository.GetAll(cancellationToken);
        }

        public async Task<Bid> GetByProductId(int id, CancellationToken cancellationToken)
        {
            return await _bidRepository.GetByProductId(id, cancellationToken);
        }

        public async Task<Bid> GetBy(int id, CancellationToken cancellationToken)
        {
            return await _bidRepository.GetBy(id, cancellationToken);   
        }

        public async Task<List<BidDto>> GetRandom(CancellationToken cancellationToken)
        {
            var list1 = await _bidRepository.GetRandom(cancellationToken);
            var list2 = new List<BidDto>();
            list2.AddRange(list1.Select(MapToDto));
            return list2;
        }

        public async Task OpenBid(int bidId, CancellationToken cancellationToken)
        {
            var bid = await GetBy(bidId, cancellationToken);
            bid.IsOpen = true;
            await Update(bid, cancellationToken);
        }

        public async Task CloseBid(int bidId, CancellationToken cancellationToken)
        {
            var bid = await GetBy(bidId, cancellationToken);
            bid.IsOpen = false;
            await Update(bid, cancellationToken);
        }

        public async Task GetFee(int bidId, int customerId, CancellationToken cancellationToken)
        {
            // payment page code here, if it was successful 1 and otherwise will return 0.
            var bid = await GetBy(bidId, cancellationToken);
            bid.IsOpen = false;
            bid.WinnerCustomerId = customerId;
            await Update(bid, cancellationToken);
        }

        public async Task<double> PayWage(int bidId, int myId, CancellationToken cancellationToken)
        {
            var bid = await GetBy(bidId, cancellationToken);
            return await _salesManService.PayWage(myId, bid.HighestPrice, cancellationToken);
        }

        public async Task DeActiveProduct(int bidId, CancellationToken cancellationToken)
        {
            var bid = await GetBy(bidId, cancellationToken);
            var p = await _productRepository.GetById(bid.ProductId, cancellationToken);
            p.IsDeleted = true;
            await _productRepository.Update(p, cancellationToken);
        }

        public async Task BuyInBid(int bidId, int offer, int userId, CancellationToken cancellationToken)
        {
            var bid = await GetBy(bidId, cancellationToken);
            if (bid.HighestPrice < offer && bid.ClosingTime > DateTime.Now)
            {
                bid.HighestPrice = offer;
                bid.WinnerCustomerId = userId;
                await _bidRepository.Update(bid, cancellationToken);
            }
            else if (bid.ClosingTime <= DateTime.Now)
            {
                bid.IsOpen = false;
                await _bidRepository.Update(bid, cancellationToken);

            }
        }

        public async Task<bool> CheckIfHasBid(int productId, CancellationToken cancellationToken)
        {
            var p = _productRepository.GetById(productId, cancellationToken);
            var b = await _bidRepository.GetByProductId(productId, cancellationToken);
            return b != null;
        }

        public BidDto MapToDto(Bid bid)
        {
            return _mapper.Map<BidDto>(bid);
        }

        public Bid MapToEntity(BidDto bid)
        {
            return _mapper.Map<Bid>(bid);
        }
    }
}
