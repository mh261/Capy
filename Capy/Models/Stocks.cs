using System.ComponentModel.DataAnnotations.Schema;

namespace Capy.Models
{
    [Table("Stocks")]
    public class Stocks
    {
        public int Id { get; set; } 
        public int CapyId { get; set; }
        public int Quantity { get; set; }
        public Capyy? Capy { get; set; }

    }
}
