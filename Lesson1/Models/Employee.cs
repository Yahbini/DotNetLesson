using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lesson1.Models;

public partial class Employee
{
    [Required]
    [MinLength(3)]
    [MaxLength(12)]
    public string Username { get; set; }

    [Required]
    [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Url]
    public string? Website { get; set; }

    [Range(18, 60)]
    public int Age { get; set; }
}

[ModelMetadataType(typeof(EmployeeMetaData))]
public partial class Employee
{
    public void Method2()
    {
        // Implementation of Method2
    }
}
