namespace ShoppingApi.ViewModels;
public class ProductsModel
{
    /// <summary>
    /// Identification Number of Category
    /// </summary>
    public int CategoryID { get; set; }
    /// <summary>
    /// Name of Category
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// price of product
    /// </summary>
    public int Price { get; set; }
    /// <summary>
    /// Number of products
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Description of a category
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }

}