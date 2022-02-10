using Microsoft.EntityFrameworkCore;
using PizzaAPI.Models;

namespace PizzaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>().HasData(SampleData.CreateSampleOrders());
            builder.Entity<Pizza>().HasData(SampleData.CreateSamplePizzas());
        }
    }
}
