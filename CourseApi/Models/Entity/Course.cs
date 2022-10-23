using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Models.Entity
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string CoursePhotoUrl { get; set; }
        public string CourseName { get; set; }
        public string Level { get; set; }
        public decimal Rate { get; set; }

        //relation
       
        public int? InstituteId { get; set; }
        [ForeignKey("InstituteId")]
        public Institute Institute { get; set; }

    }
}
