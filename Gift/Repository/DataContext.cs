global using Microsoft.EntityFrameworkCore;
using Gift.Models;

namespace Gift.Repository;

public class DataContext : DbContext
{
    protected IConfiguration configuration { get; set; }
    
    public DataContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // connect
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("GiftDB"));
    }

    // declare tables used in context`
    public DbSet<User> Users { get; set; } 
    public DbSet<Era> Eras { get; set; } 
    public DbSet<Models.Gift> Gifts { get; set; } 
}