namespace ShoppingApi.ViewModels;
public class TransactionModel
{
    /// <summary>
    /// Type of Transaction
    /// </summary>
    public string TransactionType { get; set; }
    /// <summary>
    /// Description of a transaction
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// date of transaction
    /// </summary>
    public DateTime Date { get; set; }
}
