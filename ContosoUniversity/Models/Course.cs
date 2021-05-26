using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Required]
        [Range(0, 5)]
        [Display(Name = "Кредиты")]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}