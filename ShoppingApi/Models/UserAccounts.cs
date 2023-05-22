using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class UserAccounts
    {
        [Key]
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}