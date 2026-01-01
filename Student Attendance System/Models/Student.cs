using System.ComponentModel.DataAnnotations;

namespace Student_Attendance_System.Models
{
    public class Student
    {
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RollNumber { get; set; }
    }
}
