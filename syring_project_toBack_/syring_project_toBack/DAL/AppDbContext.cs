using syring_project_toBack.Models;
using Microsoft.EntityFrameworkCore;


namespace syring_project_toBack.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AboutDoctor> AboutDoctor { get; set; }
        public DbSet<AboutDepartments> AboutDepartment { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductsComponent> ProductsComponents { get; set; }
    }
}
