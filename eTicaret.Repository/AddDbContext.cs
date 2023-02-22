using System.Reflection;
using eTicaret.Core;
using Microsoft.EntityFrameworkCore;

namespace eTicaret.Repository;

public class AddDbContext : DbContext
{
    public AddDbContext(DbContextOptions<AddDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
        
    public  DbSet<Product> Products { get; set; }
        
    public DbSet<ProductFeature> ProductFeatures { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}