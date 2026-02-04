using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Course.Database;
using Student_Course.Models;

namespace Student_Course.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{

    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> Get()
    {
        List<Student> Students= await _context.Students.ToListAsync();
        
        return Ok(Students);
    }
    [HttpPost]
    public async Task<IActionResult> Create(string name)
    {
        var std = new Student() { Name = name };
        try
        {
            await _context.Students.AddAsync(std);
            await _context.SaveChangesAsync();
            return Accepted();
        }
        catch (Exception e)
        {
            return BadRequest("Something went wrong");
        }
    }
}