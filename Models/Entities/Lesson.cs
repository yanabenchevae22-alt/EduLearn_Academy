using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Lesson
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(45)]
    public string LessonTitle { get; set; } = null!;

    public DateTime Start { get; set; }

    [ForeignKey(nameof(Course))]
    public int IdCourse { get; set; }

    public Course Course { get; set; } = null!;
}
