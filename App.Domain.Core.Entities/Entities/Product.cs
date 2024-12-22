using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Price { get; set; }

    public int? SubCategoryId { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsConfirmed { get; set; }

    public virtual SubCategory? SubCategory { get; set; }

    public Factor? Factor { get; set; }

    public Booth? Booth { get; set; }

    public int BoothId { get; set; }

    public ICollection<Comment> Comments { get; set; }

    public Bid Bid { get; set; }

    public int? BidId { get; set; }
}
