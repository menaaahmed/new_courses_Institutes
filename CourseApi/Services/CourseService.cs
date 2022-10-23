using CourseApi.Data;
using CourseApi.Models.Entity;
using CourseApi.Models.viewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Services
{
    public class CourseService
    {
        private readonly myAppDbContext _context;

        public CourseService(myAppDbContext context)
        {
            _context = context;
        }


        //addCourses
        public void AddCourse(CourseVM course)
        {
            var _course = new Course()
            {
                CourseId = course.CourseId,
                CoursePhotoUrl = course.CoursePhotoUrl,
                CourseName = course.CourseName,
                Level = course.Level,
                Rate = course.Rate,
                InstituteId = course.InstituteId

            };
            _context.Courses.Add(_course);
            _context.SaveChanges();

        }


        //getAllCourses
        public List<Course> GetAllCourses()
        {
            return _context.Courses.Include("Institute").ToList();
        }


        //getCoursesByid
        public Course GetCourseById(int id)
        {
            return _context.Courses.Include("Institute").FirstOrDefault(x => x.CourseId == id);
        }

        //getAllCoursesByName
        public List<Course> GetCourseByName(string name)
        {
            return _context.Courses.Include("Institute").Where(x => x.CourseName == name).ToList();
        }


        //getAllinstitutes
        public List<Course> GetInstitutes(string name)
        {
            return _context.Courses.Include("Institute").Where(x => x.Institute.InstituteName == name).ToList();
        }

        //two
        //public List<Institute> GetInstitutesTwo(string name)
        //{
        //    return _context.Institutes.Where(x => x.InstituteName == name).ToList();
        //}






    }
}
