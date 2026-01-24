using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Vektorel.Data.DatabaseFirstEF.Models;

namespace Vektorel.Data.DatabaseFirstEF;

public class NorthwindContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnectionString"]);
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
}