using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Repository
{
    public interface IBidRepository
    {
        Task Create(Bid bid, CancellationToken cancellationToken);
        Task Update(Bid bid, CancellationToken cancellationToken);
        Task Delete(Bid bid, CancellationToken cancellationToken);
        Task<List<Bid>> GetAll(CancellationToken cancellationToken);
        Task<Bid> GetBy(int id, CancellationToken cancellationToken);
        Task<Bid> GetByProductId(int id, CancellationToken cancellationToken);
        Task<List<Bid>> GetRandom(CancellationToken cancellationToken);
        Task<List<Bid>> SearchByName(string productName, CancellationToken cancellationToken);
    }
}
