using System.ComponentModel.DataAnnotations;

namespace Capy.Models.Dtos
{
    public class Stock
    {
        public int CapyId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative value.")]
        public int Quantity { get; set; }
    }
}
