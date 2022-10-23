using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesFront.Models.viewModel
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CoursePhotoUrl { get; set; }
        public string CourseName { get; set; }
        public string Level { get; set; }
        public decimal Rate { get; set; }


      
        public string InstitutephotoUrl { get; set; }
        public string InstituteName { get; set; }
    }
}
