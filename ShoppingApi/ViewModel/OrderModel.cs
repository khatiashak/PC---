namespace ShoppingApi.ViewModels;
public class OrderModel
{
    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Identification Number of Cart
    /// </summary>
    public int CartId { get; set; }
    /// <summary>
    /// date of order
    /// </summary>
    public DateTime Date { get; set; }
}