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

namespace App.Domain.Service;

public class AdminService : IAdminService
{
	private readonly IProductRepository _productRepository;
	private readonly ICommentRepository _commentRepository;
	private readonly ICustomerRepository _customerRepository;
	private readonly IBoothRepository _boothRepository;
    private readonly IAdminRepository _adminRepository;
    private readonly IMapper _mapper;

    public AdminService(IProductRepository productRepository, ICommentRepository commentRepository, ICustomerRepository customerRepository, IBoothRepository boothRepository, IAdminRepository adminRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _commentRepository = commentRepository;
        _customerRepository = customerRepository;
        _boothRepository = boothRepository;
        _adminRepository = adminRepository;
        _mapper = mapper;
    }

    public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
    {
        return await _adminRepository.GetAll(cancellationToken);
    }

    public async Task<Admin> GetBy(int id, CancellationToken cancellationToken)
    {
        return await _adminRepository.GetBy(id, cancellationToken);
    }

    public async Task<Admin> GetBy(string email, CancellationToken cancellationToken)
    {
        return await _adminRepository.GetBy(email, cancellationToken);
    }

    public async Task<AppUserDto> GetAdminDto(ClaimsPrincipal user, CancellationToken cancellationToken)
    {
        var adminUsername = user.Identity.Name;
        var list = await GetAll(cancellationToken);
        var list2 =
            from a in list
            where a.UserName == adminUsername
            select a;
        //return MapToDto(list2.ToList().FirstOrDefault());
        return MapToAppUserDto(list2.ToList().FirstOrDefault());
    }

    public AdminDto MapToDto(IdentityUser<int> user)
    {
        return _mapper.Map<AdminDto>(user);
    }

    public AdminDto MapToDto(Admin user)
    {
        return _mapper.Map<AdminDto>(user);
    }

    public Admin MapToEntity(IdentityUser<int> user)
    {
        var x = _mapper.Map<Admin>(MapToDto(user));
        x.Id = 0;
        return x;
    }

    public AppUserDto MapToAppUserDto(Admin user)
    {
        return _mapper.Map<AppUserDto>(user);
    }

    public async Task<bool> ConfirmSalesManeProducts(Product product, bool confirmed, CancellationToken cancellationToken)
	{
        if (!confirmed) throw new Exception("کالا توسط ادمین تایید نشد");
        product.IsConfirmed = confirmed;
        await _productRepository.Update(product, cancellationToken);
        return true;
    }

    public async Task AddAdminToDb(Admin admin, CancellationToken cancellationToken)
    {
        admin.BirthDate = DateTime.Now;
        admin.RegisterDate = DateTime.Now;
        await _adminRepository.Create(admin, cancellationToken);
    }

    public async Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken)
    {
        var list = await _productRepository.GetAll(cancellationToken);
        var unConfirmed = 
            from s in list 
            where s.IsConfirmed==false
            select s;
        return unConfirmed.ToList();
    }

    public async Task<bool> ConfirmCustomerComment(Comment comment, bool confirmed, CancellationToken cancellationToken)
    {
        if(!confirmed){await _commentRepository.Delete(comment, cancellationToken);}
        comment.IsConfirmed = confirmed;
        await _commentRepository.Update(comment, cancellationToken);
        return true;
    }

    public async Task EditCustomer(Customer customer, CancellationToken cancellationToken)
    {
        await _customerRepository.Update(customer,cancellationToken);
    }

	public async Task DeleteCustomer(int customerId, CancellationToken cancellationToken)
    {
        await _customerRepository.Delete(
            await _customerRepository.GetBy(customerId, cancellationToken),
            cancellationToken
        );
    }

	public async Task EditBooth(int boothId, Booth booth, CancellationToken cancellationToken)
    {
        await _boothRepository.Update(booth, cancellationToken);
    }

	public async Task DeleteBooth(int boothId, CancellationToken cancellationToken)
	{
        await _boothRepository.Delete(
            await _boothRepository.GetById(boothId, cancellationToken),
            cancellationToken
        );
    }

	public async Task EditProduct(Product product, CancellationToken cancellationToken)
    {
        await _productRepository.Update(product, cancellationToken);
    }

	public async Task DeleteProduct(int productId, CancellationToken cancellationToken)
	{
        await _productRepository.Delete(
            await _productRepository.GetById(productId, cancellationToken),
            cancellationToken
        );
    }

	public async Task<int> GetBoothDiscountDetails(int boothId, CancellationToken cancellationToken)
    {
        var b = await _boothRepository.GetById(boothId, cancellationToken);
        return (int)b.Medal;
    }
}