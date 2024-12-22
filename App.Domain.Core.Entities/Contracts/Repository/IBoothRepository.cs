using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface IBoothRepository
	{
		Task Create(Booth booth, CancellationToken cancellationToken);
		Task Delete(Booth booth, CancellationToken cancellationToken);
		Task Update(Booth booth, CancellationToken cancellationToken);
		Task<List<Booth>> GetAll(CancellationToken cancellationToken);
		Task<Booth> GetById(int id, CancellationToken cancellationToken);
        Task<Booth> GetBySalesMan(int salesManId, CancellationToken cancellationToken);
		Task<List<Booth>> GetPartof(int num, CancellationToken cancellationToken);
    }
}
