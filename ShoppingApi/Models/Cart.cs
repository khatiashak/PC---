using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }
    }
}