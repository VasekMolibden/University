using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [Required]
        [Display(Name = "ID курса")]
        public int CourseID { get; set; }

        [Required]
        [Display(Name = "ID студента")]
        public int StudentID { get; set; }

        [Display(Name = "Оценка")]
        [DisplayFormat(NullDisplayText = "Нет оценки")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}