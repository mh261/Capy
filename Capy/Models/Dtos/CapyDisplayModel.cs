namespace Capy.Models.Dtos
{
    public class CapyDisplayModel
    {
        public IEnumerable<Capyy> Capy { get; set; }
        public IEnumerable<GenreDTO> Genre { get; set; }
        public String STerm { get; set; } = "";
        public int GenreId { get; set; } = 0; 
    }
}
