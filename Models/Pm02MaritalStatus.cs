using System;
using System.Collections.Generic;

namespace PersonManagement.Models;

public partial class Pm02MaritalStatus
{
    public int IdMaritalStatus { get; set; }

    public string? MaritalStatus { get; set; }

    public bool? IsActive { get; set; }
}
