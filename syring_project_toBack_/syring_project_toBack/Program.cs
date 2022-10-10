using syring_project_toBack.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));


var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=doctor}/{action=Index}"
    );
app.UseStaticFiles();
app.Run();

