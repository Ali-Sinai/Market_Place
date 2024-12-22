using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
	public class CustomerHistory
	{
        public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
