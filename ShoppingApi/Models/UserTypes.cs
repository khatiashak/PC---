using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class UserTypes
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
    }
}