using System;

public class QuizResult
{

    public class QuizResult
    {
        [Key]
        public int Id { get; set; }

        public int Points { get; set; }

        [StringLength(255)]
        public string? QuizResultText { get; set; }

        [ForeignKey(nameof(Quiz))]
        public int IdQuiz { get; set; }

        public Quiz Quiz { get; set; } = null!;
    }

}
