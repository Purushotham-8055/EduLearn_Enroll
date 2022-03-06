using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSM.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course Name is Required.")]
        [StringLength(50)]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Credits is Required.")]
        [StringLength(50)]
        public string Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}