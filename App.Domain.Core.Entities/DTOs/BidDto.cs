using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DTOs
{
    //[Serializable]
    public class BidDto
    {
        public int Id { get; set; }
        public int BasePrice { get; set; }
        public int HighestPrice { get; set; }
        public bool IsOpen { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }
    }
}
