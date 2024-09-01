using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using UniversityAPI.enums;

namespace UniversityAPI.Models;

public class Person
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? CPF { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public Gender Gender { get; set; }

}
