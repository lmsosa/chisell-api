using ChiSell.Data.Seed;
using ChiSell.Domain.Orders;
using ChiSell.Domain.Payment;
using ChiSell.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ChiSell.Data.Context
{
    public class ChiSellContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ChiSellContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<Order> Orders { get; set; } = default!;

        public DbSet<Payment> Payments { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var constring = _configuration.GetConnectionString("ChiSell");
                optionsBuilder.UseSqlServer(constring, o => o.MigrationsAssembly(GetType().Assembly.GetName().Name));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new SeedData().Seed(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
