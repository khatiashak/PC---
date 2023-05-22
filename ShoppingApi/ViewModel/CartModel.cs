namespace ShoppingApi.ViewModel;
public class CartModel
{
    /// <summary>
    /// Identification Number of Product
    /// </summary>
    public int ProductId { get; set; }
    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Number of Carts ( presumably)
    /// </summary>
    public int Count { get; set; }
}