using System;

public class PromoCode
{

    public class PromoCode
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Code { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public int IdForUser { get; set; }

        public User User { get; set; } = null!;
    }

}
