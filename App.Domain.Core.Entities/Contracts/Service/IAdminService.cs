using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Core.Contracts.Service
{
	public interface IAdminService
	{
		Task<bool> ConfirmSalesManeProducts(Product product, bool confirmed, CancellationToken cancellationToken);
        Task AddAdminToDb(Admin admin, CancellationToken cancellationToken);
		Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken);
		Task<bool> ConfirmCustomerComment(Comment comment, bool confirmed, CancellationToken cancellationToken);
		Task EditCustomer(Customer customer, CancellationToken cancellationToken);
		Task DeleteCustomer(int customerId, CancellationToken cancellationToken);
		Task EditBooth(int boothId, Booth booth, CancellationToken cancellationToken);
		Task DeleteBooth(int boothId, CancellationToken cancellationToken);
		Task EditProduct(Product product, CancellationToken cancellationToken);
		Task DeleteProduct(int productId, CancellationToken cancellationToken);
        Task<List<Admin>> GetAll(CancellationToken cancellationToken);
        Task<Admin> GetBy(int id, CancellationToken cancellationToken);
        Task<Admin> GetBy(string email, CancellationToken cancellationToken);
        Task<AppUserDto> GetAdminDto(ClaimsPrincipal user, CancellationToken cancellationToken);
        AdminDto MapToDto(IdentityUser<int> user);
        AdminDto MapToDto(Admin user);
        Admin MapToEntity(IdentityUser<int> user);
        AppUserDto MapToAppUserDto(Admin user);
        Task<int> GetBoothDiscountDetails(int boothId, CancellationToken cancellationToken); //checks the medal
	}
}
