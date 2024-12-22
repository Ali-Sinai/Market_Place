namespace App.Domain.Core.Entities;

public partial class Admin
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? ShebaNumber { get; set; }

    public string? CardNumber { get; set; }

    public DateTime RegisterDate { get; set; }

    public DateTime BirthDate { get; set; }

}
