using BookShopWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
