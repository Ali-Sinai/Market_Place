using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
	public class Factor
	{
		public int Id { get; set; }
        public int SumOfPrice { get; set; }
		public Customer Customer { get; set; }
        public int CustomerId { get; set; }
	}
}
