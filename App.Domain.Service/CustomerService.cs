using System;
using System.Security.Claims;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Infrastructure.Data.SqlServer;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service;

public class CustomerService : ICustomerService
{
    private readonly IProductRepository _productRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IBoothRepository _boothRepository;
    private readonly ICommentRepository _commentRepository;
    private readonly IFactorRepository _factorRepository;
    private readonly MarketPlaceContext _dbContext;
    private readonly IMapper _mapper;

    public CustomerService(IProductRepository productRepository, ICustomerRepository customerRepository, IBoothRepository boothRepository, ICommentRepository commentRepository, IMapper mapper, MarketPlaceContext dbcContext, IFactorRepository factorRepository)
    {
        _productRepository = productRepository;
        _customerRepository = customerRepository;
        _boothRepository = boothRepository;
        _commentRepository = commentRepository;
        _mapper = mapper;
        _dbContext = dbcContext;
        _factorRepository = factorRepository;
    }

    public async Task Create(Customer customer, CancellationToken cancellationToken)
    {
        await _customerRepository.Create(customer, cancellationToken);
    }

    public async Task Delete(Customer customer, CancellationToken cancellationToken)
    {
        await _customerRepository.Delete(customer, cancellationToken);
    }

    public async Task Update(Customer customer, CancellationToken cancellationToken)
    {
        await _customerRepository.Update(customer, cancellationToken);
    }

    public async Task<Customer> GetById(int Id, CancellationToken cancellationToken)
    {
        return await _customerRepository.GetBy(Id, cancellationToken);
    }

    public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
    {
        return await _customerRepository.GetAll(cancellationToken);
    }

    public async Task<List<Product>> GetProductsbySalesMan(int salesManId, CancellationToken cancellationToken)
    {
        var b = await _boothRepository.GetBySalesMan(salesManId, cancellationToken);
        return b.Products.ToList();
    }

    public async Task<List<Product>> GetProductsbyCategory(int categoryId, CancellationToken cancellationToken)
    {
        return await _productRepository.GetByCategory(categoryId, cancellationToken);

    }

    public async Task<List<Product>> GetAllProducts(CancellationToken cancellationToken)
    {
        return await _productRepository.GetAll(cancellationToken);
    }

    public async Task BuyNormal(int myId, int productId, CancellationToken cancellationToken)
    {
        var p = await _productRepository.GetById(productId, cancellationToken);
        var c = await _customerRepository.GetBy(myId, cancellationToken);
        FactorProduct factorProduct = new FactorProduct { FactorID = myId, ProductId = productId };
        _dbContext.FactorProduct.Add(factorProduct);
        c.Factor.SumOfPrice += Convert.ToInt32(Convert.ToDouble(p.Price));
        _dbContext.Factors.Update(c.Factor);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task AddComment(Comment comment, CancellationToken cancellationToken)
    {
        await _commentRepository.Create(comment, cancellationToken);
    }

    public async Task<List<Product>> GetPurchaseHistory(int myId, CancellationToken cancellationToken)
    {
        return await _customerRepository.GetCustomerHistory(myId, cancellationToken);
    }

    public CustomerDto MapToDto(IdentityUser<int> user)
    {
        return _mapper.Map<CustomerDto>(user);
    }

    public CustomerDto MapToDto(Customer user)
    {
        return _mapper.Map<CustomerDto>(user);
    }

    public Customer MapToEntity(IdentityUser<int> user)
    {
        var x =  _mapper.Map<Customer>(MapToDto(user));
        x.Id = 0;
        return x;
    }

    public async Task AddToDb(Customer user, CancellationToken cancellationToken)
    {
        user.BirthDate = DateTime.Now;
        user.RegisterDate = DateTime.Now;
        user.Address = "here";
        user.IsDeleted = false;
        await _customerRepository.Create(user, cancellationToken);
        await _factorRepository.Create(new Factor { Customer = user, CustomerId = user.Id, Id=0, SumOfPrice = 0 }, cancellationToken);
    }

    public AppUserDto MapToAppUserDto(Customer user)
    {
        return _mapper.Map<AppUserDto>(user);
    }

    public async Task<AppUserDto> GetCustomerDto(ClaimsPrincipal user, CancellationToken cancellationToken)
    {
        var customerUsername = user.Identity.Name;
        var list = await GetAll(cancellationToken);
        var list2 =
            from a in list
            where a.UserName == customerUsername
            select a;
        //return MapToDto(list2.ToList().FirstOrDefault());
        return MapToAppUserDto(list2.ToList().FirstOrDefault());
    }

    public async Task<List<Product>> GetFactor(int customerId, CancellationToken cancellationToken)
    {
        return await _customerRepository.GetFactor(customerId, cancellationToken);
    }

    public async Task<List<Bid>> GetProductsBuyInBid(int customerId, CancellationToken cancellationToken)
    {
        return await _dbContext.Bids.Where(e => e.WinnerCustomerId == customerId && e.IsOpen == false)
            .Include(e => e.Product)
            .ToListAsync(cancellationToken);
    }


    public async Task ClearFactor(int customerId, CancellationToken cancellationToken)
    {
        var x = _dbContext.FactorProduct.Where(fp => fp.FactorID == customerId);
        var productIds = x.Select(e => e.ProductId);
        var customerHistories = productIds.Select(productId => new CustomerHistory { CustomerId = customerId, ProductId = productId });
        _dbContext.CustomerHistories.AddRange(customerHistories);
        _dbContext.FactorProduct.RemoveRange(x);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}