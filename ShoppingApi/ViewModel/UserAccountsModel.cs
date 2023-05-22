namespace ShoppingApi.ViewModels;
public class UserAccountsModel
{

    /// <summary>
    /// Identification Number of User
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Identification Number of Account Type
    /// </summary>
    public int TypeId { get; set; }
    /// <summary>
    /// Name of an account
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// age of an user
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Gender of an user
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// Address of an user
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// ContactNumber of an user
    /// </summary>
    public string ContactNumber { get; set; }

    /// <summary>
    /// name of an user
    /// </summary>
    public string UserName { get; set; }
    /// <summary>
    /// Password of an user
    /// </summary>
    public string Password { get; set; }

}
