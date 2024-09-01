using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models;

public class Teacher : Person
{
    [Key]
    public int TeacherId { get; set; }
    
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    public string? Telephone { get; set; }
    public IEnumerable<string>? Certificates { get; set; }
    
    [Required]
    public float paymentHoursPrice { get; set; }

}
