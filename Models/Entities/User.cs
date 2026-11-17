using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EduLearn_Academy.Models
{
    public class User
    {


        public class User
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(45)]
            public string UserName { get; set; } = null!;

            [Required]
            [StringLength(45)]
            [EmailAddress]
            public string Email { get; set; } = null!;

            [Required]
            [StringLength(255)]
            public string PasswordHash { get; set; } = null!;

            [Range(0, 120)]
            public int Age { get; set; }

            [ForeignKey(nameof(Role))]
            public int RoleID { get; set; }

            public Role Role { get; set; } = null!;

            public ICollection<UserCourse> UserCourses { get; set; }
                = new List<UserCourse>();

            public ICollection<Enrollment> Enrollments { get; set; }
                = new List<Enrollment>();

            public ICollection<PromoCode> PromoCodes { get; set; }
                = new List<PromoCode>();

            public ICollection<Review> Reviews { get; set; }
                = new List<Review>();

            public ICollection<Certificate> Certificates { get; set; }
                = new List<Certificate>();
        }



    }
}
