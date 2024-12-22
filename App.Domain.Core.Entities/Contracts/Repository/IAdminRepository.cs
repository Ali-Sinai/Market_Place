using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Repository
{
	public interface IAdminRepository
	{
		Task Create(Admin admin, CancellationToken cancellationToken);
		Task Delete(Admin admin, CancellationToken cancellationToken);
		Task Update(Admin admin, CancellationToken cancellationToken);
		Task<List<Admin>> GetAll(CancellationToken cancellationToken);
		Task<Admin> GetBy(int id, CancellationToken cancellationToken);
		Task<Admin> GetBy(string email, CancellationToken cancellationToken);

	}
}
