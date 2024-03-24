namespace Flashcardia.Repostories
{
    public class DeckWriter
    {
        private readonly ApplicationDbContext _context;

        public DeckWriter(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Deck deck)
        {
            await _context.Decks.AddAsync(deck);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Deck deck)
        {
            _context.Decks.Update(deck);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Deck deck)
        {
            _context.Decks.Remove(deck);
            await _context.SaveChangesAsync();
        }
    }
}
