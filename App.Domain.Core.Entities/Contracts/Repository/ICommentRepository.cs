using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Repository
{
    public interface ICommentRepository
    {
        Task Create(Comment comment, CancellationToken cancellationToken);
        Task Delete(Comment comment, CancellationToken cancellationToken);
        Task Update(Comment comment, CancellationToken cancellationToken);
        Task<List<Comment>> GetAllForProduct(int productId, CancellationToken cancellationToken);
        Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        Task<Comment> GetById(int commentId, CancellationToken cancellationToken);
    }
}
