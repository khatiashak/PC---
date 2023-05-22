using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}