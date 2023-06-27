using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class Booth
{
    public string Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
