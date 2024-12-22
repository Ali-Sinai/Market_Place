using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.Contracts.Service;

public interface IBidService
{
    Task Create(Bid bid, CancellationToken cancellationToken);
    Task Delete(Bid bid, CancellationToken cancellationToken);
    Task Update(Bid bid, CancellationToken cancellationToken);
    Task<List<Bid>> GetAll(CancellationToken cancellationToken);
    Task<Bid> GetBy(int id, CancellationToken cancellationToken);
    Task<Bid> GetByProductId(int id, CancellationToken cancellationToken);
    Task<List<BidDto>> GetRandom(CancellationToken cancellationToken);
    Task OpenBid(int bidId, CancellationToken cancellationToken);
    Task CloseBid(int bidId, CancellationToken cancellationToken);
    Task GetFee(int bidId, int customerId, CancellationToken cancellationToken);
    Task<double> PayWage(int bidId, int myId, CancellationToken cancellationToken);
    Task DeActiveProduct(int bidId, CancellationToken cancellationToken);
    Task BuyInBid(int bidId, int offer, int userId, CancellationToken cancellationToken);
    Task<bool> CheckIfHasBid(int productId, CancellationToken cancellationToken);
    BidDto MapToDto(Bid bid);
    Bid MapToEntity(BidDto bid);
}