using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
	public interface ICustomerRepository
	{
		Task Create(Customer customer, CancellationToken cancellationToken);
		Task Delete(Customer customer, CancellationToken cancellationToken);
		Task Update(Customer customer, CancellationToken cancellationToken);
		Task<List<Customer>> GetAll(CancellationToken cancellationToken);
		Task<Customer> GetBy(int id, CancellationToken cancellationToken);
		Task<Customer> GetBy(string email, CancellationToken cancellationToken);
		Task<List<Product>> GetCustomerHistory(int id, CancellationToken cancellationToken);
        Task<List<Product>> GetFactor(int customerId, CancellationToken cancellationToken);


    }
}
