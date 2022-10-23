﻿using CourseApi.Models;
using CourseApi.Models.Entity;
using CourseApi.Models.viewModel;
//using CoursesFront.Models.viewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CoursesFront.Controllers
{
    public class joinMvcController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Course> course = null;
            using (var client = new HttpClient())
            {
                var responseTask = await client.GetAsync("http://localhost:49798/api/Course/get-all-courses");
                if (responseTask.IsSuccessStatusCode)
                {
                    List<Course> listOFCourse = responseTask.Content.ReadAsAsync<List<Course>>().Result;
                    course = listOFCourse;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "there is an error");
                };

            }
            return View(course);
        }



        //public async Task<IActionResult> Index()
        //{
        //    IEnumerable<viewModel> course = null;
        //    using (var client = new HttpClient())
        //    {
        //        var responseTask = await client.GetAsync("http://localhost:49798/api/Course/get-all-courses");
        //        if (responseTask.IsSuccessStatusCode)
        //        {
        //            List<viewModel> listOFCourse = responseTask.Content.ReadAsAsync<List<viewModel>>().Result;
        //            course = listOFCourse;
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(string.Empty, "there is an error");
        //        };

        //    }
        //    return View(course);
        //}




        //search
        public async Task<IActionResult> searchByName(string search)
        {
            ViewData["getCourse"] = search;
            IEnumerable<Course> courseSearch = null;
            HttpClient hc = new HttpClient();

            hc.BaseAddress = new Uri("http://localhost:49798/api/course/");
            var result = hc.GetAsync("get-all-courses-byName/" + search);
            result.Wait();

            var readData = result.Result;
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<List<Course>>();
                displayData.Wait();
                courseSearch = displayData.Result;

            }
            else
            {
                ModelState.AddModelError(string.Empty, "there is an error");
            };
            return View(courseSearch);
        }



        //filter
        public async Task<IActionResult> filterByName(string name)
        {

            IEnumerable<Course> instituteSearch = null;
            HttpClient hc = new HttpClient();

            hc.BaseAddress = new Uri("http://localhost:49798/api/course/");
            var result = hc.GetAsync("get-all-Institutes-byName/" + name);
            result.Wait();

            var readData = result.Result;
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<List<Course>>();
                displayData.Wait();
                instituteSearch = displayData.Result;

            }
            else
            {
                ModelState.AddModelError(string.Empty, "there is an error");
            };
            return View(instituteSearch);
        }


    }
}