using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface IProductRepository
	{
		Task Create(Product product, CancellationToken cancellationToken);
		Task Delete(Product product, CancellationToken cancellationToken);
		Task Update(Product product, CancellationToken cancellationToken);
		Task<List<Product>> GetAll(CancellationToken cancellationToken);
		Task<Product> GetById(int id, CancellationToken cancellationToken);
		Task<List<Product>> GetByBoothId(int boothId, CancellationToken cancellationToken);
        Task<List<Product>> GetByCategory(int categoryId, CancellationToken cancellationToken);
        Task<List<Product>> GetNotConfirmedProducts(CancellationToken cancellationToken);
        Task AddImage(string imageUrl, int id, CancellationToken cancellationToken);
	}
}
