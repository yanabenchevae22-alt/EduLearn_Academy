using System;

public class Certificate
{

    public class Certificate
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int TheUserId { get; set; }

        public int Grade { get; set; }

        public User User { get; set; } = null!;
    }

}
