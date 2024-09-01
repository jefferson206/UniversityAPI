using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models;

public class Course
{
    [Key]
    public int CourseId { get; set; }
    
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(300)]
    public string? Description { get; set; }

    [Required]
    public int hours{ get; set; }

    [Required]
    public float price { get; set; }

}
