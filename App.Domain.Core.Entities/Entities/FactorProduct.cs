using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
	public class FactorProduct
	{
        public int Id { get; set; }
		public int FactorID { get; set; }
		public Factor Factor { get; set; }


		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
