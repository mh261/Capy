using Capy.Data;
using Microsoft.EntityFrameworkCore;
using Capy.Repositories;

namespace Capy.Repositories
{
    public class CapyRepository: ICapyRepository
    {
            private readonly ApplicationDbContext _context;
            public CapyRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task AddBook(Capy capy)
            {
                _context.Capy.Add(Capy);
                await _context.SaveChangesAsync();
            }

        
    }
}
