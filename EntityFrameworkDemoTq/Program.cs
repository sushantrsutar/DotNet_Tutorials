using EntityFrameworkDemoTq.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//to read the connection string from app setting json file
string strcon = builder.Configuration.GetConnectionString("DefaultConnection");
//pass connection string to applicationdbcontex 
builder.Services.AddDbContext<ApplicationDbContex>(op => op.UseSqlServer(strcon));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
