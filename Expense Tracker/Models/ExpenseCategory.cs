using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }

        // Navigation property
        public List<Expense>? Expenses { get; set; }
    }
}
