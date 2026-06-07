
using System.Numerics;
using System.Runtime.InteropServices;

public class BudgetManager
{
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        Transactions.Add(transaction);
    }

    public List<Transaction> GetAllTransactions()
    {
        return Transactions;
    }

    public decimal GetTotalIncome()
    {
        decimal totalIncome = 0;
        foreach (var transaction in Transactions)
        {
            if (transaction.TransactionType == TransactionType.Income)
            {
                totalIncome += transaction.Amount;          
            }
        }
        return totalIncome;
    }
    
    public decimal GetTotalExpenses()
    {
        decimal totalExpenses = 0;
        foreach (var transaction in Transactions)
        {
            if (transaction.TransactionType == TransactionType.Expense)
            {
                totalExpenses += transaction.Amount;
            }
        }
        return totalExpenses;
    }

    public decimal GetBalance()
    {
        return GetTotalIncome() - GetTotalExpenses();
    }
}