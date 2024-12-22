using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
	public partial class Comment
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsConfirmed { get; set; }
	}
}
