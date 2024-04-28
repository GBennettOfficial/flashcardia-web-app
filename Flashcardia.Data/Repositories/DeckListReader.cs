using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace Flashcardia.Data.Repositories
{
    public class DeckListReader : IReadDecks
    {
        private readonly ApplicationDbContext _context;

        public DeckListReader(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Deck>> Get(string userId)
        {
            return await _context.Decks
                .Where(x => x.UserId == userId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
