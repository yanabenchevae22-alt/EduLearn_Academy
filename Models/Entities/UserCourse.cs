using System;

public class UserCourse
{

    [PrimaryKey(nameof(IdUser), nameof(TheIdCourse))]
    public class UserCourse
    {
        public int IdUser { get; set; }

        public int TheIdCourse { get; set; }

        [ForeignKey(nameof(IdUser))]
        public User User { get; set; } = null!;

        [ForeignKey(nameof(TheIdCourse))]
        public Course Course { get; set; } = null!;
    }

}

