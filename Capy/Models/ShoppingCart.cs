using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
namespace Capy.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int Id { get; set; }
        [Required]
        public String UserId {  get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<CartDetails> CartDetails { get; set; }
    }
}
