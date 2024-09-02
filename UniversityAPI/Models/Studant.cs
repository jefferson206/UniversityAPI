using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models;

public class Studant : Person
{
    [Key]
    public int StudantId { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    public string? Telephone { get; set; }
}
