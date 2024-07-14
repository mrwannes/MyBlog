using Microsoft.EntityFrameworkCore;
using MyBlog.Web.Data;
using MyBlog.Web.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TestDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

app.Run();
