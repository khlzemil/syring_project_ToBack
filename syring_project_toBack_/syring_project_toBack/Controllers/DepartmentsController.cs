using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using syring_project_toBack.DAL;
using syring_project_toBack.ViewModels.Departments;

namespace syring_project_toBack.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var aboutDepartment = await _appDbContext.AboutDepartment.ToListAsync();

            var model = new DepartmentsIndexViewModel
            {
                AboutDepartments = aboutDepartment
            };

            return View(model);
        }
    }
}
