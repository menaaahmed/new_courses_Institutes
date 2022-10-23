using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Models.viewModel
{
    public class CourseVM
    {
       
        public int CourseId{ get; set; }
        public string CoursePhotoUrl { get; set; }
        public string CourseName { get; set; }
        public string Level { get; set; }
        public decimal Rate { get; set; }


        public int? InstituteId { get; set; }
    }
}
