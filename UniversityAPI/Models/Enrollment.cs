namespace UniversityAPI.Models;

public class Enrollment
{
    public int EnrollmentId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public GraduationClass? GraduationClass { get; set; }
    public Studant? Studant { get; set; }

}
