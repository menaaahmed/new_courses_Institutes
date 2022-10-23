using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Models.Entity
{
    public class Institute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstituteId { get; set; }
        public string InstitutephotoUrl { get; set; }
        public string InstituteName { get; set; }

        //relation
        public List<Course> Courses { get; set; }
    }
}
