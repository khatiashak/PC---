namespace ShoppingApi.ViewModels;
public class PaymentModel
{
    /// <summary>
    /// Identification Number of Product
    /// </summary>
    public int ProductId { get; set; }
    /// <summary>
    /// Number of Products that are paid
    /// </summary>
    public int Quantity { get; set; }
    /// <summary>
    /// date of payment
    /// </summary>
    public DateTime Date { get; set; }
    /// <summary>
    /// Amount of Payments
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }
}