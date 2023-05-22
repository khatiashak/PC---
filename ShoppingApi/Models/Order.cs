using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
        public DateTime Date { get; set; }
    }
}