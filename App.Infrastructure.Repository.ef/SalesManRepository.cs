using System;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class SalesManRepository : ISalesManRepository
{
	private readonly MarketPlaceContext _dbContext;

	public SalesManRepository(MarketPlaceContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task Create(SalesMan salesMan, CancellationToken cancellationToken)
	{
        _dbContext.Entry(salesMan).State = EntityState.Added;
        _dbContext.SalesMen.Add(salesMan);
        await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(SalesMan salesMan, CancellationToken cancellationToken)
	{
		//_dbContext.SalesMen.Remove(salesMan);
		//await _dbContext.SaveChangesAsync(cancellationToken);
        salesMan.IsDeleted = true;
        await Update(salesMan, cancellationToken);
    }

	public async Task Update(SalesMan salesMan, CancellationToken cancellationToken)
	{
		_dbContext.SalesMen.Update(salesMan);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<SalesMan>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.SalesMen.ToListAsync(cancellationToken);
	}

	public async Task<SalesMan> GetBy(int id, CancellationToken cancellationToken)
	{
        return await _dbContext.SalesMen.Where(e => e.Id == id).FirstOrDefaultAsync(cancellationToken);
	}

    public async Task<SalesMan> GetBy(string email, CancellationToken cancellationToken)
	{
		return await _dbContext.SalesMen.Where(e => e.Email == email).FirstOrDefaultAsync(cancellationToken);
	}
}