using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Lab2_1.Models;

var builder = WebApplication.CreateBuilder(args);

string connectionDb = builder.Configuration.GetConnectionString("DefaultConnection")
                      ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationContext>(option => option.UseNpgsql(connectionDb));
// Add services to the container.

builder.Services.AddRazorPages();

var app = builder.Build();


app.MapStaticAssets();

app.MapRazorPages()
    .WithStaticAssets();

app.Run();