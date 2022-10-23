using CourseApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseApi.Controllers
{
    public class InstituteController : Controller
    {
        private readonly InstutuseService _service;

        public InstituteController(InstutuseService InstutuseService)
        {
            _service = InstutuseService;

        }

        [HttpGet("get-all-institutes")]
        public IActionResult GetAllInstitutes()
        {
            var allInstitutes = _service.GetAll();
            return Ok(allInstitutes);
        }
    }
}
