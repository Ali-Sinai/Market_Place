using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Entities;

namespace App.Domain.Core.Contracts.Service
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllNotConfirmed(CancellationToken cancellationToken);
        Task<Comment> GetById(int id, CancellationToken cancellationToken);
    }
}
