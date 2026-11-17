using System;

public class Review
{

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int TheIdUser { get; set; }

        [StringLength(45)]
        public string? Feedback { get; set; }

        public User User { get; set; } = null!;
    }

}
