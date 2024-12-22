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
	public interface ISalesManService
    {
        SalesManDto MapToDto(IdentityUser<int> user);
        SalesManDto MapToDto(SalesMan user);
        AppUserDto MapToAppUserDto(SalesMan user);
        SalesMan MapToEntity(IdentityUser<int> user);
		Task AddToDb(SalesMan entity, CancellationToken cancellationToken);
		Task Update(SalesMan user, CancellationToken cancellationToken);
        Task<List<SalesMan>> GetAll(CancellationToken cancellationToken);
        Task<SalesMan> GetBy(int id, CancellationToken cancellationToken);
		Task CreateBooth(int myId, Booth booth, CancellationToken cancellationToken);
		Task AddProduct(Product product,int boothId, CancellationToken cancellationToken); // add image inside this
		Task SaleAsBid(int productId, int boothId, CancellationToken cancellationToken);
		Task SaleNormal(int productId, int boothId, CancellationToken cancellationToken);
		Task SetProductInActive(int productId, int boothId, CancellationToken cancellationToken);
		Task<double> PayWage(int myId,int moneyReceived, CancellationToken cancellationToken);
		Task GetMedal(int myId, CancellationToken cancellationToken);
		Task EditPersonalInfo(SalesMan salesMan, CancellationToken cancellationToken);
		Task<AppUserDto> GetSalesManDto(ClaimsPrincipal user, CancellationToken cancellationToken);
		Task<List<Bid>> GetBidsList(AppUserDto user, CancellationToken cancellationToken);
        Task CreateFirstBooth(string username, CancellationToken cancellationToken);
    }
}
