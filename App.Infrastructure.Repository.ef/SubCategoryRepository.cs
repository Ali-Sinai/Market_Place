using System;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class SubCategoryRepository : ISubCategoryRepository
{
	private readonly MarketPlaceContext _dbContext;

	public SubCategoryRepository(MarketPlaceContext dbContext)
	{
		_dbContext = dbContext;
	}
	public async Task Create(SubCategory subCategory, CancellationToken cancellationToken)
	{
		_dbContext.SubCategories.Add(subCategory);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(SubCategory subCategory, CancellationToken cancellationToken)
	{
		_dbContext.SubCategories.Remove(subCategory);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Update(SubCategory subCategory, CancellationToken cancellationToken)
	{
		_dbContext.SubCategories.Update(subCategory);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.SubCategories.ToListAsync(cancellationToken);
	}

	public async Task<SubCategory> GetBy(int id, CancellationToken cancellationToken)
	{
		return await _dbContext.SubCategories.FindAsync(id, cancellationToken);
	}

	public async Task<List<Product>> GetProductsWithSubCategory(SubCategory subCategory, int id, CancellationToken cancellationToken)
	{
		return await _dbContext.Products
			.Where(e => e.SubCategory == subCategory)
			.ToListAsync(cancellationToken);
	}

    public async Task<List<SubCategory>> GetPartof(int num, CancellationToken cancellationToken)
    {
        return await _dbContext.SubCategories.Take(num).ToListAsync(cancellationToken);
    }
}