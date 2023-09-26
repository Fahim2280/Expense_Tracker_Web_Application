namespace Expense_Tracker.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        // Navigation properties
        public User? User { get; set; }
        public ExpenseCategory? Category { get; set; }
    }
}
