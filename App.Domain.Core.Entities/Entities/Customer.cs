namespace App.Domain.Core.Entities;

public partial class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public Factor? Factor { get; set; }

    public string? ShebaNumber { get; set; }

    public string? CardNumber { get; set; }

    public DateTime RegisterDate { get; set; }

    public DateTime BirthDate { get; set; }

    public ICollection<Comment>? Comments { get; set; }

    public Bid Bid { get; set; }

    public int? BidId { get; set; }

}
