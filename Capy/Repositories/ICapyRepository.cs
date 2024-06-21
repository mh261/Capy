using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Capy.Models;
namespace Capy.Repositories
{
    public interface ICapyRepository
    {
        Task AddCapy(Capyy Capy);
        Task DeleteCapy(Capyy capy);
        Task<Capyy?> GetCapyById(int id);

        Task<IEnumerable<Capyy>> GetCapys();
        Task UpdateCapy(Capyy capy);
    }
}
