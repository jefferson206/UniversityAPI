using Microsoft.EntityFrameworkCore;
using UniversityAPI.Models;

namespace UniversityAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Studant>? Studants { get; set; }
    public DbSet<Teacher>? Teacher { get; set; }
    public DbSet<Course>? Course { get; set; }
    public DbSet<ClassSubject>? ClassSubject { get; set; }

}