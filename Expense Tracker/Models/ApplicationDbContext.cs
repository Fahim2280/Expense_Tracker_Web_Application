using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships

            // Expense - User relationship
            modelBuilder.Entity<Expense>()
                .HasOne(e => e.User)
                .WithMany(u => u.Expenses)
                .HasForeignKey(e => e.UserID);

            // Expense - ExpenseCategory relationship
            modelBuilder.Entity<Expense>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Expenses)
                .HasForeignKey(e => e.CategoryID);

            // ExpenseCategory - Expense relationship (Reverse navigation, one-to-many)
            modelBuilder.Entity<ExpenseCategory>()
                .HasMany(c => c.Expenses)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryID);
        }
    }

}
