using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface ICategoryRepository
	{
		Task Create(Category category, CancellationToken cancellationToken);
		Task Delete(Category category, CancellationToken cancellationToken);
		Task Update(Category category, CancellationToken cancellationToken);
		Task<List<Category>> GetAll(CancellationToken cancellationToken);
		Task<Category> GetBy(int id, CancellationToken cancellationToken);
        Task<List<Category>> GetPartof(int num, CancellationToken cancellationToken);

    }
}
