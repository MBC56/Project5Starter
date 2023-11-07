using System.ComponentModel.DataAnnotations;

namespace CourseCatalog.Models
{
    public class Course
    { 
        public int Id { get; set; }
        
        [Display(Name = "Course Name")]
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }
        public int RoomNumber { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
