namespace Flashcardia.Repostories
{
    public class CardListReader
    {
        private readonly ApplicationDbContext _context;

        public CardListReader(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Card>> Get(int deckId)
        {
            return await _context.Cards
                .Where(x => x.DeckId == deckId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
