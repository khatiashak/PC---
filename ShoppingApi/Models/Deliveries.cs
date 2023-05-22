using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Deliveries
    {
        [Key]
        public int DeliveryId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}