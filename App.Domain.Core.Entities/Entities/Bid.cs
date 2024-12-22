using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Entities
{
    public class Bid
    {
        public int Id { get; set; }
        public int BasePrice { get; set; }
        public int HighestPrice { get; set; }
        public bool IsOpen { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool HasWinner { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Customer WinnerCustomer { get; set; }
        public int? WinnerCustomerId { get; set; }

    }
}
