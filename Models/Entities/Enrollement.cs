using System;

public class Enrollement
{

    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public User User { get; set; } = null!;
    }

}
