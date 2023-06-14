using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class Product
{
    public string Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? SubCategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public virtual SubCategory? SubCategory { get; set; }
}
