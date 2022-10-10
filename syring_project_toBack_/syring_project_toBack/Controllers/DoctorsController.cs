using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using syring_project_toBack.Models;
using syring_project_toBack.DAL;
using syring_project_toBack.ViewModels.Doctors;

namespace syring_project_toBack.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DoctorsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var aboutDoctor = await _appDbContext.AboutDoctor.ToListAsync();

            var model = new DoctorsIndexViewModel
            {
                AboutDoctor = aboutDoctor
            };

            return View(model);
        }
    }
}
