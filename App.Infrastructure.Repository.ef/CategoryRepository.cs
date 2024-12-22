using System;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class CategoryRepository : ICategoryRepository
{
	private readonly MarketPlaceContext _dbContext;

	public CategoryRepository(MarketPlaceContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task Create(Category category, CancellationToken cancellationToken)
	{
		_dbContext.Categories.Add(category);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(Category category, CancellationToken cancellationToken)
	{
		_dbContext.Categories.Remove(category);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Update(Category category, CancellationToken cancellationToken)
	{
		_dbContext.Categories.Update(category);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.Categories.ToListAsync(cancellationToken);
	}

	public async Task<Category> GetBy(int id, CancellationToken cancellationToken)
	{
		return await _dbContext.Categories.FindAsync(id, cancellationToken);
	}

    public async Task<List<Category>> GetPartof(int num, CancellationToken cancellationToken)
    {
        return await _dbContext.Categories.Take(num).ToListAsync(cancellationToken);
    }
}