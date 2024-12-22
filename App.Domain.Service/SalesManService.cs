using System;
using System.Security.Claims;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Enums;
using App.Infrastructure.Data.SqlServer;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service;

public class SalesManService : ISalesManService
{
	private readonly ISalesManRepository _salesManRepository;
	private readonly IBoothRepository _boothRepository;
	private readonly IProductRepository _productRepository;
    private readonly MarketPlaceContext _dbContext;
    private readonly IMapper _mapper;

    public SalesManService(ISalesManRepository salesManRepository, IBoothRepository boothRepository, IProductRepository productRepository, IMapper mapper, MarketPlaceContext dbContext)
    {
        _salesManRepository = salesManRepository;
        _boothRepository = boothRepository;
        _productRepository = productRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public SalesManDto MapToDto(IdentityUser<int> user)
    {
        return _mapper.Map<SalesManDto>(user);
    }

    public SalesManDto MapToDto(SalesMan user)
    {
        var x = _mapper.Map<SalesManDto>(user);
        x.BoothId = x.Id;
        return x;
    }

    public SalesMan MapToEntity(IdentityUser<int> user)
    {
        
        var x = _mapper.Map<SalesMan>(MapToDto(user));
        x.Id = 0;
        return x;
    }

    public AppUserDto MapToAppUserDto(SalesMan user)
    {
        return _mapper.Map<AppUserDto>(user);
    }

    public async Task AddToDb(SalesMan entity, CancellationToken cancellationToken)
    {
        entity.BirthDate = DateTime.Now;
        entity.RegisterDate = DateTime.Now;
        entity.Address = "here";
        await _salesManRepository.Create(entity, cancellationToken);
        await CreateFirstBooth(entity.Email, cancellationToken);
    }

    public async Task Update(SalesMan user, CancellationToken cancellationToken)
    {
        await _salesManRepository.Update(user, cancellationToken);
    }

    public async Task<List<SalesMan>> GetAll(CancellationToken cancellationToken)
    {
        return await _salesManRepository.GetAll(cancellationToken);
    }

    public async Task<SalesMan> GetBy(int id, CancellationToken cancellationToken)
    {
        return await _salesManRepository.GetBy(id, cancellationToken);
    }
    public async Task<SalesMan> GetBy(string email, CancellationToken cancellationToken)
    {
        return await _salesManRepository.GetBy(email, cancellationToken);
    }

    public async Task CreateBooth(int myId, Booth booth, CancellationToken cancellationToken)
    {
        booth.SalesMan = await _salesManRepository.GetBy(myId, cancellationToken);
        await _boothRepository.Create(booth, cancellationToken);
    }

    public async Task CreateFirstBooth(string email, CancellationToken cancellationToken)
    {
        var x = await GetBy(email: email, cancellationToken);
        var booth = new Booth { Id = x.Id, Medal = 0, Name = x.UserName + "Shop" };
        await _boothRepository.Create(booth, cancellationToken);
    }

    public async Task AddProduct(Product product, int boothId, CancellationToken cancellationToken)
    {
        product.BoothId = boothId;
        await _productRepository.Create(product, cancellationToken);
    }

	public Task SaleAsBid(int productId, int boothId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public Task SaleNormal(int productId, int boothId, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public async Task SetProductInActive(int productId, int boothId, CancellationToken cancellationToken)
    {
        var p = await _productRepository.GetById(productId, cancellationToken);
		p.IsDeleted = false;
        await _productRepository.Update(p, cancellationToken);
    }

	public async Task<double> PayWage(int myId,int moneyReceived, CancellationToken cancellationToken)
    {
        var s = await _salesManRepository.GetBy(myId, cancellationToken);
        var wage = s.Wage == (int)Medal.Silver ? 0.015 : (s.Wage == (int)Medal.Bronze ? 0.01 : 0.005);
        return wage * moneyReceived;
        // payment code here
    }

	public async Task GetMedal(int myId, CancellationToken cancellationToken)
    {
        var s = await _salesManRepository.GetBy(myId, cancellationToken);
        s.Wage = s.Wage == (int)Medal.Bronze ? (int)Medal.Silver : (int)Medal.Gold;
        await _salesManRepository.Update(s, cancellationToken);
    }

	public async Task EditPersonalInfo(SalesMan salesMan, CancellationToken cancellationToken)
    {
        await _salesManRepository.Update(salesMan, cancellationToken);
    }

    public async Task<AppUserDto> GetSalesManDto(ClaimsPrincipal user, CancellationToken cancellationToken)
    {
        var salesManUsername = user.Identity.Name;
        var list = await GetAll(cancellationToken);
        var list2 =
            from a in list
            where a.UserName == salesManUsername
            select a;
        //return MapToDto(list2.ToList().FirstOrDefault());
        return MapToAppUserDto(list2.ToList().FirstOrDefault());
    }

    public async Task<List<Bid>> GetBidsList(AppUserDto user,CancellationToken cancellationToken)
    {
        return await _dbContext.Bids.Where(e => e.Product.BoothId == user.Id)
            .Include(e => e.Product)
            .ToListAsync(cancellationToken);
    }

    
}