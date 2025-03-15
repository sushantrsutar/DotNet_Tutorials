using Microsoft.EntityFrameworkCore;
using WebApiDemoTQ.Models;
using WebApiDemoTQ.Repsitories;
using WebApiDemoTQ.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//for db connection
var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(conn));
//------------------

//add scop
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeServices, EmployeeService>();

//-----------------

//cors --cross origin resoures sharing
builder.Services.AddCors(op => op.AddDefaultPolicy(x => x.WithOrigins("http://localhost:4200")
.AllowAnyHeader().AllowAnyMethod()));

//-------
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseCors();
app.Run();
