using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace App.Infrastructure.Repository.ef
{
    public class BidRepository : IBidRepository
    {
        private readonly MarketPlaceContext _dbContext;
        Faker faker = new Faker();

        public BidRepository(MarketPlaceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Bid bid, CancellationToken cancellationToken)
        {
            await _dbContext.Bids.AddAsync(bid, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(Bid bid, CancellationToken cancellationToken)
        {
            _dbContext.Bids.Update(bid);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Bid bid, CancellationToken cancellationToken)
        {
            _dbContext.Bids.Remove(bid);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Bid>> GetAll(CancellationToken cancellationToken)
        {
            var bids2 = _dbContext.Bids
                .Include(b => b.Product)
                .ToListAsync(cancellationToken);

            return await bids2;
        }

        public async Task<Bid> GetBy(int id, CancellationToken cancellationToken)
        {
            //var list = await GetAll(cancellationToken);
            //var list2 = 
            //    from bid in list
            //    where bid.Id == id
            //    select bid;

            return await _dbContext.Bids
                .Where(b => b.Id == id)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(b => b.Product.BidId == b.Id);

        }

        public async Task<Bid> GetByProductId(int id, CancellationToken cancellationToken)
        {
            return await _dbContext.Bids.Where(e => e.ProductId == id).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<Bid>> GetRandom(CancellationToken cancellationToken)
        {
            var list = new List<Bid>();
            var count = _dbContext.Bids.Count();
            for (var i = 0; i < 10; i++)
            {
                list.Add(
                    await _dbContext.Bids.Where(e => e.Id == faker.Random.Int(1, count))
                        .Include(b => b.Product)
                        .FirstOrDefaultAsync(cancellationToken)
                    );
            }
            return list;
        }

        public async Task<List<Bid>> SearchByName(string productName, CancellationToken cancellationToken)
        {
            return await _dbContext.Bids.Where(e => e.Product.Name.Contains(productName))
                .ToListAsync(cancellationToken);
        }
    }
}
