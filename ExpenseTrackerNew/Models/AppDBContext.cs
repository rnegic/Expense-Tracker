using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerNew.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
