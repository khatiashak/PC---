using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Transaction
    {
        [Key]
        public int  TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }
    }
}