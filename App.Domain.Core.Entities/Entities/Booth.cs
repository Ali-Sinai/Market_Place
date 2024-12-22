using App.Domain.Core.Enums;

namespace App.Domain.Core.Entities;

public partial class Booth
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public Medal Medal { get; set; }

    public SalesMan SalesMan { get; set; }

    public ICollection<Product> Products { get; set; }
}
