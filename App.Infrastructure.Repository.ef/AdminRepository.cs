using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef
{
	public class AdminRepository : IAdminRepository
	{
		private readonly MarketPlaceContext _dbContext;

		public AdminRepository(MarketPlaceContext context)
		{
			    _dbContext = context;
		}
		public async Task Create(Admin admin, CancellationToken cancellationToken)
		{
            _dbContext.Entry(admin).State = EntityState.Added;
            _dbContext.Admins.Add(admin);
			await _dbContext.SaveChangesAsync(cancellationToken);
		}

		public async Task Delete(Admin admin, CancellationToken cancellationToken)
		{
			_dbContext.Admins.Remove(admin);
			await _dbContext.SaveChangesAsync(cancellationToken);
		}

		public async Task Update(Admin admin, CancellationToken cancellationToken)
		{
			_dbContext.Admins.Update(admin);
			await _dbContext.SaveChangesAsync(cancellationToken);
		}

		public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
		{
			return await _dbContext.Admins.ToListAsync(cancellationToken);
		}

		public async Task<Admin> GetBy(int id, CancellationToken cancellationToken)
		{
			return await _dbContext.Admins.FindAsync(id, cancellationToken);
		}

		public async Task<Admin> GetBy(string email, CancellationToken cancellationToken)
		{
			return await _dbContext.Admins.FirstOrDefaultAsync(e => e.Email == email, cancellationToken);
			//return await _dbContext.Admins.Where(e => e.Email == email).FirstOrDefaultAsync(cancellationToken);
		}
	}
}
