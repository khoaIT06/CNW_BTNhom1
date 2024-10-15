using System;
using System.Collections.Generic;

namespace CustomerApi.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? Birthday { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }
}
