using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Repository;

public interface IFactorRepository
{
    Task Create(Factor factor, CancellationToken cancellationToken);
    Task Update(Factor factor, CancellationToken cancellationToken);
    Task Delete(Factor factor, CancellationToken cancellationToken);
    Task<List<Factor>> GetAll(CancellationToken cancellationToken);
    Task<List<Factor>> GetCustomerFactors(int customerId, CancellationToken cancellationToken);
}