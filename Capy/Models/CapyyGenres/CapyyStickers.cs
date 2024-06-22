namespace Capy.Models.CapyyGenres
{
    public class CapyyStickers : Capyy
    {
        // Quantity per pack
        public int PackSize { get; set; }

        public void Create()
        {
            Console.WriteLine("Stickers");
        }
    }
}
