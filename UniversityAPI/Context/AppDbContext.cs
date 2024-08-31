using Microsoft.EntityFrameworkCore;

namespace UniversityAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

}