using System.ComponentModel.DataAnnotations;

public enum TransactionType { Income, Expense }

public class Transaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public TransactionType TransactionType { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    [Required]
    public string Category { get; set; }
    public bool Recurrent { get; set; }
}