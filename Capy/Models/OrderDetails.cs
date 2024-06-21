using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
namespace Capy.Models
{
    [Table("OrderDetail")]
    public class OrderDetails
    {
     
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CapyId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double unitPrice { get; set; }
        [Required]
        public Order order { get; set; }
        public Capyy capy { get; set; }  
    }
}
