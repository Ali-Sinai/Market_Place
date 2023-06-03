using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class BoothSalesMan
{
    public int SalesManId { get; set; }

    public int BoothId { get; set; }

    public virtual Booth Booth { get; set; } = null!;

    public virtual SalesMan SalesMan { get; set; } = null!;
}
