using CourseApi.Data;
using CourseApi.Models.Entity;
using CourseApi.Models.viewModel;
using System.Collections.Generic;
using System.Linq;

namespace CourseApi.Services
{
    public class InstutuseService
    {
        private readonly myAppDbContext _context;

        public InstutuseService(myAppDbContext context)
        {
            _context = context;
        }



        public List<InstuateVM> GetAll()
        {
            return _context.Institutes.Select(e => new InstuateVM()
            {
                InstituteId=e.InstituteId,
                InstituteName=e.InstituteName
            }).ToList();



        }
    }
}
