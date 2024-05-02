using Flashcardia.Global.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Flashcardia.Data.Repositories
{
    public class CardListReader : IDataAccessReader<int, List<Card>>
    {
        private readonly ApplicationDbContext _context;

        public CardListReader(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Card>>> Read(int id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<Card> cards = _context.Cards
                        .Where(x => x.DeckId == id)
                        .AsNoTracking()
                        .ToList();

                    return new ServiceResponse<List<Card>>(isSuccess: true, value: cards, null, null);
                }
                catch (Exception ex)
                {
                    return new ServiceResponse<List<Card>>(isSuccess: false, value: null, message: "failure reading cards", exception: ex);
                }
            });
        }
    }
}
