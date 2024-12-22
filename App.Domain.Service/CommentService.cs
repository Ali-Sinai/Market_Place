using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using App.Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Domain.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly MarketPlaceContext _dbContext;

        public CommentService(ICommentRepository commentRepository, MarketPlaceContext dbContext)
        {
            _commentRepository = commentRepository;
            _dbContext = dbContext;
        }

        public async Task<List<Comment>> GetAllNotConfirmed(CancellationToken cancellationToken)
        {
            return await _dbContext.Comments.Where(e => e.IsConfirmed == false && e.IsDeleted == false)
                .Include(e => e.Product)
                .ToListAsync(cancellationToken);
        }

        public async Task<Comment> GetById(int id, CancellationToken cancellationToken)
        {
            return await _commentRepository.GetById(id, cancellationToken);
        }
    }
}
