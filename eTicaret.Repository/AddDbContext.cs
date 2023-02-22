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
        modelBuilder.Entity<ProductFeature>().HasData(
            new ProductFeature()
        {
            Id = 1,
            Color = "Mavi",
            Height = 22,
            Width = 33,
            ProductId = 1
            
        },
            new ProductFeature()
            {
            Id = 2,
            Color = "Saarıı",
            Height = 22,
            Width = 33,
            ProductId = 2
        });
        
        base.OnModelCreating(modelBuilder);
    }
}