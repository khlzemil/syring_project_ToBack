using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using syring_project_toBack.DAL;
using syring_project_toBack.ViewModels.Products;

namespace syring_project_toBack.Controllers
{
    public class ProductsController : Controller
    {

        private readonly AppDbContext _appDbContext;

        public ProductsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _appDbContext.Products.
                                                    Include(x => x.ProductsComponents).ToListAsync();

            var model = new ProductsIndexViewModel
            {
                Products = products
            };

            return View(model);
        }
    }
}
