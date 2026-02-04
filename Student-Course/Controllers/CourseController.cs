using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Course.Database;
using Student_Course.Models;

namespace Student_Course.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{

    private readonly AppDbContext _context;

    public CourseController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> Get()
    {
        List<Course> courses= await _context.Courses.ToListAsync();
        
        return Ok(courses);
    }
    [HttpPost]
    public async Task<IActionResult> Create(string name)
    {
        var course = new Course() { CourseName = name };
        try
        {
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();
            return Accepted();
        }
        catch (Exception e)
        {
            return BadRequest("Something went wrong");
        }
    }
}