using Flashcardia.Global.Interfaces.DataAccess;

namespace Flashcardia.Data.Repositories
{
    public class CardWriter : IWriteCard
    {
        private readonly ApplicationDbContext _context;

        public CardWriter(ApplicationDbContext context)
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
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Card card)
        {
            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();
        }
    }
}
