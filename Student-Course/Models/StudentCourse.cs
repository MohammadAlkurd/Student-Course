using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Course.Models;

public class StudentCourse
{
    [Required]
    [Key]
    public Guid Id { get; set; }= Guid.NewGuid();
    
    public Guid CourseId { get; set; }
    
    [ForeignKey("CourseId")]
    public Course Course { get; set; }
    
    public Guid StudentId { get; set; }
    
    [ForeignKey("StudentId")]
    public Student Student { get; set; }
    
}