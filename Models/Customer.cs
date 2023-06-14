using System;
using System.Collections.Generic;

namespace Market_Place.Models;

public partial class Customer
{
    public string Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
