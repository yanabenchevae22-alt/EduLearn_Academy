using System;

public class Role
{


    
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string RoleName { get; set; } = null!;

        public ICollection<User> Users { get; set; } = new List<User>();
    

}

