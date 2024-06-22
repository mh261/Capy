using Capy.Models.CapyyGenres;

namespace Capy.Models.Factory
{
    public class CapyyFactory
    {
        public static Capyy CreateProd(Genre genre)
        {
            switch (genre.GenreName)
            {
                case "Stickers":
                    return new CapyyStickers();
                case "Plushies":
                    return new CapyyPlushies();
                default:
                    throw new NotSupportedException($"{genre.GenreName} is not available");

            }
        }
    }
}
