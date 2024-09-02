using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UniversityAPI.Models;

public class Course
{

    public Course()
    {
        ClassSubjects = new Collection<ClassSubject>();
    }

    [Key]
    public int CourseId { get; set; }
    
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(300)]
    public string? Description { get; set; }

    [Required]
    public int hours { get; set; }

    [Required]
    public float price { get; set; }
    [JsonIgnore]
    public ICollection<ClassSubject> ClassSubjects { get; set; }
}
