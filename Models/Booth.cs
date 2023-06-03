using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class Booth
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Decription { get; set; }

    public string? ImageUrl { get; set; }
}
