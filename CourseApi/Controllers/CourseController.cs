using CourseApi.Data;
using CourseApi.Models;
using CourseApi.Models.Entity;
using CourseApi.Models.viewModel;
using CourseApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //   api/course
    public class CourseController : ControllerBase
    {


        private readonly CourseService _service;

        public CourseController(CourseService CourseService)
        {
            _service = CourseService;

        }

        //create
        [HttpPost("add-course")]
        public IActionResult AddCourse([FromBody] CourseVM coursevm)
        {
            _service.AddCourse(coursevm);
            return Ok();
        }

        //getall
        [HttpGet("get-all-courses")]
        public IActionResult GetAllCourses()
        {
            var allCourses = _service.GetAllCourses();
            return Ok(allCourses);
        }


        //getbyid
        [HttpGet("get-course-by-id/{id}")]
        public IActionResult GetCourseById(int id)
        {
            var Course = _service.GetCourseById(id);
            return Ok(Course);
        }


        //getallByCourseName (search)
        [HttpGet("get-all-courses-byName/{name}")]
        public IActionResult GetAllCoursesByName(string name)
        {
            var allCourses = _service.GetCourseByName(name);
            return Ok(allCourses);
        }




        //getallInstitutes
        [HttpGet("get-all-Institutes-byName/{name}")]
        public IActionResult GetAllInstituteByName(string name)
        {
            var allInstitutes = _service.GetInstitutes(name);
            return Ok(allInstitutes);
        }




        //
        //[HttpGet("get-all")]
        //public IActionResult getall()
        //{
        //    var allInstitutes = _service.GetAll();
        //    return Ok(allInstitutes);
        //}


    }
}
