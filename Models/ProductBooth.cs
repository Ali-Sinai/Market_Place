using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class ProductBooth
{
    public int ProductId { get; set; }

    public int BoothId { get; set; }

    public virtual Booth Booth { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
