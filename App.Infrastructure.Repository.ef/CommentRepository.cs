using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repository.ef
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MarketPlaceContext _dbContext;

        public CommentRepository(MarketPlaceContext context)
        {
            _dbContext = context;
        }
        public async Task Create(Comment comment, CancellationToken cancellationToken)
        {
            _dbContext.Comments.Add(comment);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Comment comment, CancellationToken cancellationToken)
        {
            //_dbContext.Comments.Remove(comment);
            //await _dbContext.SaveChangesAsync(cancellationToken);
            comment.IsDeleted = true;
            await Update(comment, cancellationToken);
        }

        public async Task Update(Comment comment, CancellationToken cancellationToken)
        {
            _dbContext.Comments.Update(comment);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Comment>> GetAllForProduct(int productId, CancellationToken cancellationToken)
        {
            return await _dbContext.Comments
                .Where(e => e.ProductId == productId && e.IsDeleted == false && e.IsConfirmed == true)
                .Include(e => e.Customer)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            return await _dbContext.Comments.Where(e =>  e.IsDeleted == false).ToListAsync(cancellationToken);
        }

        public async Task<Comment> GetById(int commentId, CancellationToken cancellationToken)
        {
            var x = await _dbContext.Comments.Where(e => e.Id == commentId).ToListAsync(cancellationToken);
            return x.FirstOrDefault();
        }
    }
}
