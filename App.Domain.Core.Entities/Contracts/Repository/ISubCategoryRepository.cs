using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface ISubCategoryRepository
	{
		Task Create(SubCategory subCategory, CancellationToken cancellationToken);
		Task Delete(SubCategory subCategory, CancellationToken cancellationToken);
		Task Update(SubCategory subCategory, CancellationToken cancellationToken);
		Task<List<SubCategory>> GetAll(CancellationToken cancellationToken);
		Task<SubCategory> GetBy(int id, CancellationToken cancellationToken);
		Task<List<Product>> GetProductsWithSubCategory(SubCategory subCategory, int id, CancellationToken cancellationToken);
        Task<List<SubCategory>> GetPartof(int num, CancellationToken cancellationToken);

    }
}
