using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface ISalesManRepository
	{
		Task Create(SalesMan salesMan, CancellationToken cancellationToken);
		Task Delete(SalesMan salesMan, CancellationToken cancellationToken);
		Task Update(SalesMan salesMan, CancellationToken cancellationToken);
		Task<List<SalesMan>> GetAll(CancellationToken cancellationToken);
		Task<SalesMan> GetBy(int id, CancellationToken cancellationToken);
		Task<SalesMan> GetBy(string email, CancellationToken cancellationToken);
    }
}