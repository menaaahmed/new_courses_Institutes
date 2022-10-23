using CourseApi.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Data
{
    public class myAppDbContext : DbContext
    {
        public myAppDbContext(DbContextOptions<myAppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Institute> Institutes { get; set; }
    }
}
