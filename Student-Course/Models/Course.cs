using System.ComponentModel.DataAnnotations;

namespace Student_Course.Models;

public class Course
{
    [Required]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    [MaxLength(50)]
    public string CourseName { get; set; }
}