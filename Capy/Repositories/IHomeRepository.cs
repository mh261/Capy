using Capy.Models;

namespace Capy
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Capy>> GetBooks(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Genre>> Genres();
    }
}
