using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTrackerNew.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options):base(options)
        {
            Database.Migrate();
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
