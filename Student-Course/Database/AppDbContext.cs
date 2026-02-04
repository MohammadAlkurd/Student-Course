using Microsoft.EntityFrameworkCore;
using Student_Course.Models;

namespace Student_Course.Database;

public class AppDbContext :DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentsCourses { get; set; }
}