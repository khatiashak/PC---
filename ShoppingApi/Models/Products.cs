using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}
