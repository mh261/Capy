namespace Capy.Models.CapyyGenres
{
    public class CapyyPlushies : Capyy
    {
        // Softness rated from 1 to 5
        public byte Softness { get; set; }

        public void Create()
        {
            Console.WriteLine("Plushies");
        }
    }
}
