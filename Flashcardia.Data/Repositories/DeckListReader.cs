using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace Flashcardia.Data.Repositories
{
    public class DeckListReader : IDataAccessReader<string, List<Deck>>
    {
        private readonly ApplicationDbContext _context;

        public DeckListReader(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Deck>>> Read(string id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Deck> decks = _context.Decks
                        .Where(x => x.UserId == id)
                        .AsNoTracking()
                        .ToList();

                    return new ServiceResponse<List<Deck>>(isSuccess: true, value: decks, null, null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse<List<Deck>>(isSuccess: false, value: null, message: "failure reading cards", exception: ex);
                }
            });
        }
    }
}
