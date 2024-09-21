using System.ComponentModel.DataAnnotations;

// Declare the data schema
namespace DotNetExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required]
        public string? Description { get; set; }

    }
}