using System.Reflection;
using ShoppingApi.Configurations;
using ShoppingApi.Models;
using Microsoft.EntityFrameworkCore;
using ShoppingApi.ViewModel;

namespace ShoppingApi;
public class ShoppingDBContext : DbContext
{
    public DbSet<Cart> Cart { get; set; }
    
    public DbSet<Categories> Categories_ { get; set; }
    public DbSet<Deliveries> Deliveries_ { get; set; }
    public DbSet<Order> Order_ { get; set; }
    public DbSet<Payment> Payment_ { get; set; }
    public DbSet<Products> Products_ { get; set; }
    public DbSet<UserAccounts> UserAccounts_ { get; set; }
    public DbSet<UserTypes> UserTypes_ { get; set; }

    public ShoppingDBContext(DbContextOptions<ShoppingDBContext> options) : base(options)

    {

    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CartConfiguration).Assembly);
        
    }
}
