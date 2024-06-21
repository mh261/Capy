using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capy.Models
{
   
    [Table("CartDetails")]
    public class CartDetails
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int CapyId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public Capyy Capy { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
