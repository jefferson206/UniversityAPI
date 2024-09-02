using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models;

public class ClassSubject
{
    [Key]
    public int ClassSubjectId { get; set; }
    [Required]
    public string? Subject { get; set; }
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    [Required]
    public int CourseId { get; set; }
    public Course? Course { get; set; }

}