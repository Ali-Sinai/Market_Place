using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DTOs;
using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken);
        Task<Product> GetById(int productId,CancellationToken cancellationToken);
        Task<List<Product>> GetByBoothId(int boothId, CancellationToken cancellationToken);
        Task<List<Product>> GetAll(CancellationToken cancellationToken);
        Task Update(Product product, CancellationToken cancellationToken);
        Task Delete(int productId, CancellationToken cancellationToken);
        Task Create(Product product, CancellationToken cancellationToken);
        Task<int> HasBid(int productId, CancellationToken cancellationToken);
        ProductDto MapToDto(Product product, CancellationToken cancellationToken);
        Product MapToEntity(ProductDto productDto, CancellationToken cancellationToken);
        Task<List<Product>> GetByCategory(int categoryId, CancellationToken cancellationToken);
    }
}
