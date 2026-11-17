using System;

public class Question
{

    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Quiz))]
        public int QuizId { get; set; }

        [Range(0, 1000)]
        public int Points { get; set; }

        [Required]
        [StringLength(255)]
        public string TextOfQuestion { get; set; } = null!;

        public Quiz Quiz { get; set; } = null!;
    }

}
