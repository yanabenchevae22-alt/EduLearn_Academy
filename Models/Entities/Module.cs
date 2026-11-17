using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Module
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(45)]
    public string ModuleName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    [ForeignKey(nameof(Course))]
    public int IdForCourse { get; set; }

    public Course Course { get; set; } = null!;

    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
