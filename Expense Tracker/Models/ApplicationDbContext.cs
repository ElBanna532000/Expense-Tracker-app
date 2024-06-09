using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        // Properties corresponding to model classes 
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
