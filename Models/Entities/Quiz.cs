using System;

public class Quiz
{

    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string QuizName { get; set; } = null!;

        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Module))]
        public int ModuleID { get; set; }

        public Module Module { get; set; } = null!;

        public ICollection<Question> Questions { get; set; }
            = new List<Question>();

        public ICollection<QuizResult> QuizResults { get; set; }
            = new List<QuizResult>();
    }

}
