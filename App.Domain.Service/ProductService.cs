using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IBidService _bidService;
        private readonly IMapper _mapper;
        private readonly MarketPlaceContext _dbContext;

        public ProductService(IProductRepository productRepository, IMapper mapper, IBidService bidService, MarketPlaceContext dbContext)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _bidService = bidService;
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken)
        {   
            return await _productRepository.GetNotConfirmedProducts(cancellationToken);
        }

        public async Task<Product> GetById(int productId, CancellationToken cancellationToken)
        {
            return await _productRepository.GetById(productId, cancellationToken);
        }

        public async Task<List<Product>> GetByBoothId(int boothId, CancellationToken cancellationToken)
        {
            return await _productRepository.GetByBoothId(boothId, cancellationToken);
        }

        public async Task<List<Product>> GetAll(CancellationToken cancellationToken)
        {
            return await _productRepository.GetAll(cancellationToken);
        }

        public async Task Update(Product product, CancellationToken cancellationToken)
        {
            await _productRepository.Update(product, cancellationToken);
        }

        public async Task Delete(int productId, CancellationToken cancellationToken)
        {
            await _productRepository.Delete( await _productRepository.GetById(productId, cancellationToken), cancellationToken);
        }

        public async Task Create(Product product, CancellationToken cancellationToken)
        {
            await _productRepository.Create(product, cancellationToken);
        }

        public async Task<int> HasBid(int productId, CancellationToken cancellationToken)
        {
            var b = await _bidService.GetByProductId(productId, cancellationToken);
            return b != null ? b.Id : 0;
        }

        public ProductDto MapToDto(Product product, CancellationToken cancellationToken)
        {
            return _mapper.Map<ProductDto>(product);
        }

        public Product MapToEntity(ProductDto productDto, CancellationToken cancellationToken)
        {
            return _mapper.Map<Product>(productDto);
        }

        public async Task<List<Product>> GetByCategory(int categoryId, CancellationToken cancellationToken)
        {
            return await _dbContext.Products.Where(e => e.SubCategory.CategoryId == categoryId)
                .Include(e => e.SubCategory)
                .Include(d => d.SubCategory.Category)
                .ToListAsync(cancellationToken);
        }
    }
}
