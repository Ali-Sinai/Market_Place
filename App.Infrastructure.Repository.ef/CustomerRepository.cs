using System;
using System.Data;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef;

public class CustomerRepository : ICustomerRepository
{
	private readonly MarketPlaceContext _dbContext;

	public CustomerRepository(MarketPlaceContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task Create(Customer customer, CancellationToken cancellationToken)
	{
        _dbContext.Entry(customer).State = EntityState.Added;
        _dbContext.Customers.Add(customer);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task Delete(Customer customer, CancellationToken cancellationToken)
	{
		//_dbContext.Customers.Remove(customer);
		//await _dbContext.SaveChangesAsync(cancellationToken);
        customer.IsDeleted = true;
		await Update(customer, cancellationToken);
    }

	public async Task Update(Customer customer, CancellationToken cancellationToken)
	{
		_dbContext.Customers.Update(customer);
		await _dbContext.SaveChangesAsync(cancellationToken);
	}

	public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
	{
		return await _dbContext.Customers.ToListAsync(cancellationToken);
	}

	public async Task<Customer> GetBy(int id, CancellationToken cancellationToken)
	{
        return await _dbContext.Customers.Where(c => c.Id == id)
            .Include(c => c.Factor)
            .FirstOrDefaultAsync(cancellationToken);
    }

	public async Task<Customer> GetBy(string email, CancellationToken cancellationToken)
	{
		return await _dbContext.Customers.FindAsync(email, cancellationToken);
	}

    public async Task<List<Product>> GetCustomerHistory(int id, CancellationToken cancellationToken)
    {
        var x = await _dbContext.CustomerHistories.Where(e => e.CustomerId == id).ToListAsync(cancellationToken);
        var list = new List<Product>();
        foreach (var item in x)
        {
			list.Add(await _dbContext.Products.Where(e => e.Id == item.ProductId).FirstOrDefaultAsync(cancellationToken));
        }
		return list;
    }

    public async Task<List<Product>> GetFactor(int customerId, CancellationToken cancellationToken)
    {
        var list = await _dbContext.FactorProduct
            .Where(e => e.FactorID == customerId)
            .Include(e => e.Product)
            .ToListAsync(cancellationToken);
		var list2 = list.Select(e => e.Product).ToList();
        return list2;
    }
}