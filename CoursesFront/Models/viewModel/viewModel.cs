using CourseApi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesFront.Models.viewModel
{
    public class viewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Institute> institutes { get; set; }
    }
}
