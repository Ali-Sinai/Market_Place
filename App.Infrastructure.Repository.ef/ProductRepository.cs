using System;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class ProductRepository : IProductRepository
{
	private readonly MarketPlaceContext _dbContext;

	public ProductRepository(MarketPlaceContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task Create(Product product, CancellationToken cancellationToken)
	{
			_dbContext.Products.Add(product);
			await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(Product product, CancellationToken cancellationToken)
	{
		//_dbContext.Products.Remove(product);
		//await _dbContext.SaveChangesAsync(cancellationToken);
        product.IsDeleted = true;
        await Update(product, cancellationToken);
    }

	public async Task Update(Product product, CancellationToken cancellationToken)
	{
		_dbContext.Products.Update(product);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.Products.Where(e => e.IsDeleted == false && e.IsConfirmed == true).ToListAsync(cancellationToken);
	}

	public async Task<Product> GetById(int id, CancellationToken cancellationToken)
	{
		var x = await _dbContext.Products.Where(e => e.IsDeleted == false && e.Id == id).ToListAsync(cancellationToken);
        return x.FirstOrDefault();
    }

    public async Task<List<Product>> GetByBoothId(int boothId, CancellationToken cancellationToken)
    {
        return await _dbContext.Products.Where(e => e.BoothId == boothId && (e.IsDeleted == false && e.IsConfirmed == true)).ToListAsync(cancellationToken);
    }

    public async Task<List<Product>> GetByCategory(int categoryId, CancellationToken cancellationToken)
    {
        return await _dbContext.Products.Where(e => e.SubCategory.CategoryId == categoryId && (e.IsConfirmed == true && e.IsDeleted == false)).ToListAsync(cancellationToken);
    }

    public async Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken)
    {
        return await _dbContext.Products.Where(e => e.IsConfirmed == false && e.IsDeleted == false).ToListAsync(cancellationToken);
    }

    public async Task AddImage(string imageUrl, int id, CancellationToken cancellationToken)
	{
		var p = _dbContext.Products.FirstOrDefault(e => e.Id == id);
		p.ImageUrl = imageUrl;
		await Update(p,cancellationToken);
	}
}