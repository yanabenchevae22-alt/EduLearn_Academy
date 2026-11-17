using System;

public class Course
{
	public Course()
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string CourseName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public ICollection<Module> Modules { get; set; } = new List<Module>();

    public ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
   }
}
