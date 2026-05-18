using Microsoft.EntityFrameworkCore;

namespace Lab2_1.Models;

public class ApplicationContext : DbContext
{
    public DbSet<ProfileInfo> Profiles { get; set; } = null!;

    public ApplicationContext(DbContextOptions<ApplicationContext> options) :
        base(options)
    {
        Database.EnsureCreated();
    }
}
