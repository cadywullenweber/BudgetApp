
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
}