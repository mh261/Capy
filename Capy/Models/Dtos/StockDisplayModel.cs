namespace Capy.Models.Dtos
{
    public class StockDisplayModel
    {
        public int Id { get; set; }
        public int CapyId { get; set; }
        public int Quantity { get; set; }
        public string? CapyName { get; set; }
    }
}
