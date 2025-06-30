using mayden.shoppingapp.models;
using Microsoft.EntityFrameworkCore;

namespace mayden.shoppingapp.data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AppDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db");
        }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}