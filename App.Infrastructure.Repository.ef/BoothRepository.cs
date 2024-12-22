using System;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class BoothRepository : IBoothRepository
{
	private readonly MarketPlaceContext _dbContext;
	private readonly IProductRepository _productRepository;

	public BoothRepository(MarketPlaceContext dbContext, IProductRepository productRepository)
	{
		_dbContext = dbContext;
		_productRepository = productRepository;
	}
	public async Task Create(Booth booth, CancellationToken cancellationToken)
	{
		await _dbContext.Booths.AddAsync(booth, cancellationToken);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(Booth booth, CancellationToken cancellationToken)
	{
		_dbContext.Booths.Remove(booth);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Update(Booth booth, CancellationToken cancellationToken)
	{
		_dbContext.Booths.Update(booth);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<Booth>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.Booths.ToListAsync(cancellationToken);
	}

	public async Task<Booth> GetById(int id, CancellationToken cancellationToken)
	{
		return await _dbContext.Booths.FindAsync(id, cancellationToken);
	}

    public async Task<Booth> GetBySalesMan(int salesManId, CancellationToken cancellationToken)
    {
        return await _dbContext.Booths.Where(e => e.SalesMan.Id == salesManId).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<List<Booth>> GetPartof(int num, CancellationToken cancellationToken)
    {
        return await _dbContext.Booths.Take(num).ToListAsync(cancellationToken);
    }
}