using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capy.Models
{
    [Table("Capy")]
    public class Capyy
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string? CapyName { get; set; }

        [Required]
        [MaxLength(40)]
        public string? Producer { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetails> OrderDetail { get; set; }
        public List<CartDetails> CartDetail { get; set; }
        public Stocks Stock { get; set; }

        [NotMapped]
        public string GenreName { get; set; }
        [NotMapped]
        public int Quantity { get; set; }

    }
}
