using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UniversityAPI.Models;

public class ClassSubject
{
    [Key]
    public int ClassSubjectId { get; set; }
    [Required]
    public string? Subject { get; set; }
    public int TeacherId { get; set; }
    [JsonIgnore]
    public Teacher? Teacher { get; set; }
    [Required]
    public int CourseId { get; set; }
    [JsonIgnore]
    public Course? Course { get; set; }

}