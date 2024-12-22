using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service
{
    public class BoothService : IBoothService
    {
        private readonly IProductRepository _productRepository;
        private readonly IBoothRepository _boothRepository;

        public BoothService(IProductRepository productRepository, IBoothRepository boothRepository)
        {
            _productRepository = productRepository;
            _boothRepository = boothRepository;
        }

        public async Task Create(Booth booth, CancellationToken cancellationToken)
        {
            await _boothRepository.Create(booth, cancellationToken);
        }

        public async Task Delete(Booth booth, CancellationToken cancellationToken)
        {
            await _boothRepository.Delete(booth, cancellationToken);
        }

        public async Task Update(Booth booth, CancellationToken cancellationToken)
        {
            await _boothRepository.Update(booth, cancellationToken);
        }

        public async Task<List<Booth>> GetAll(CancellationToken cancellationToken)
        {
            return await _boothRepository.GetAll(cancellationToken);
        }

        public async Task<Booth> GetById(int id, CancellationToken cancellationToken)
        {
            return await _boothRepository.GetById(id, cancellationToken);
        }

        public async Task<Booth> GetBySalesMan(int salesMan, CancellationToken cancellationToken)
        {
            return await _boothRepository.GetBySalesMan(salesMan, cancellationToken);
        }

        public async Task AddProduct(Product product, int boothId, CancellationToken cancellationToken)
        {
            var b = await GetById(boothId, cancellationToken);
            await _productRepository.Create(product, cancellationToken);

        }

        public async Task AddImage(string imageUrl, int id, CancellationToken cancellationToken)
        {
            var b = await _boothRepository.GetById(id, cancellationToken);
            b.ImageUrl = imageUrl;
            await _boothRepository.Update(b, cancellationToken);
        }

        public async Task<List<Product>> GetAllProducts(int boothId, CancellationToken cancellationToken)
        {
            return await _productRepository.GetByBoothId(boothId, cancellationToken);
        }

        public async Task<List<Booth>> GetPartof(int num, CancellationToken cancellationToken)
        {
            return await _boothRepository.GetPartof(num, cancellationToken);
        }
    }
}
