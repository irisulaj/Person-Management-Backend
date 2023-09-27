using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonManagement.Models;

public partial class Pm03User
{
    [Key]
    public int IdUser { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Role { get; set; }

    public string? Password { get; set; }
}
