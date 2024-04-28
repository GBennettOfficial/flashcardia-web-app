using System.Threading.Tasks;

namespace Flashcardia.Data.Repositories
{
    public class DeckWriter : IDataAccessWriter<Deck>
    {
        private readonly ApplicationDbContext _context;

        public DeckWriter(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse> Create(Deck deck)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Decks.Add(deck);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure adding deck to database", exception: ex);
                }
            });
        }

        public async Task<ServiceResponse> Update(Deck deck)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Decks.Update(deck);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure updating deck in database", exception: ex);
                }
            });
        }

        public async Task<ServiceResponse> Delete(Deck deck)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Decks.Remove(deck);
                    _context.SaveChanges();
                    return new ServiceResponse(isSuccess: true, message: "", exception: null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse(isSuccess: false, message: "failure deleting deck from database", exception: ex);
                }
            });
        }
    }
}
