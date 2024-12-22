using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef
{
    public class FactorRepository : IFactorRepository
    {
        private readonly MarketPlaceContext _dbContext;

        public FactorRepository(MarketPlaceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Factor factor, CancellationToken cancellationToken)
        {
            _dbContext.Entry(factor).State = EntityState.Added;
            _dbContext.Factors.Add(factor);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Update(Factor factor, CancellationToken cancellationToken)
        {
            _dbContext.Factors.Update(factor);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Factor factor, CancellationToken cancellationToken)
        { 
            _dbContext.Factors.Remove(factor);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Factor>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Factors.ToListAsync(cancellationToken);
        }

        public async Task<List<Factor>> GetCustomerFactors(int customerId, CancellationToken cancellationToken)
        {
            return await _dbContext.Factors.Where(e => e.Customer.Id == customerId).ToListAsync(cancellationToken);
        }
    }
}
