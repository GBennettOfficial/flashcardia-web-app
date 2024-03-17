namespace Flashcardia.Models
{
    public class DeckWriter
    {
        private readonly ApplicationDbContext _context;

        public DeckWriter(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Card card)
        {
            await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Card card)
        {
            _context.Update(card);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Card card)
        {
            _context.Remove(card);
            await _context.SaveChangesAsync();
        }
    }
}
