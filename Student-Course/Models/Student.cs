using System.ComponentModel.DataAnnotations;

namespace Student_Course.Models;

public class Student
{
    [Required]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
}