namespace Capy.Models.Dtos
{
    public class OderDetailsModelDTO
    {
        public string DivId { get; set; }
        public IEnumerable<OrderDetails> OrderDetail { get; set; }
    }
}
