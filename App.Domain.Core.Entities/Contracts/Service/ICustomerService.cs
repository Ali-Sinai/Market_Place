using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.Contracts.Service
{
	public interface ICustomerService
	{
		Task Create(Customer customer, CancellationToken cancellationToken);
		Task Delete(Customer customer, CancellationToken cancellationToken);
		Task Update(Customer customer, CancellationToken cancellationToken);
        Task<Customer> GetById(int Id, CancellationToken cancellationToken);
		Task<List<Customer>> GetAll(CancellationToken cancellationToken);
        Task<List<Product>> GetProductsbySalesMan(int salesManId, CancellationToken cancellationToken);
		Task<List<Product>> GetProductsbyCategory(int categoryId, CancellationToken cancellationToken);
		Task<List<Product>> GetAllProducts(CancellationToken cancellationToken);
		Task BuyNormal(int myId, int productId, CancellationToken cancellationToken);
		Task AddComment(Comment comment, CancellationToken cancellationToken);
		Task<List<Product>> GetPurchaseHistory(int myId,CancellationToken cancellationToken);
        CustomerDto MapToDto(IdentityUser<int> user);
        CustomerDto MapToDto(Customer user);
        Customer MapToEntity(IdentityUser<int> user);
        AppUserDto MapToAppUserDto(Customer user);
        Task AddToDb(Customer user, CancellationToken cancellationToken);
        Task<AppUserDto> GetCustomerDto(ClaimsPrincipal user, CancellationToken cancellationToken);
        Task<List<Product>> GetFactor(int customerId, CancellationToken cancellationToken);
		Task<List<Bid>> GetProductsBuyInBid(int customerId, CancellationToken cancellationToken);
		Task ClearFactor(int customerId, CancellationToken cancellationToken);

    }
}
