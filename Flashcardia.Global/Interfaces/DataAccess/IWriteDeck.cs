

namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IWriteDeck
    {
        Task Create(Deck deck);
        Task Delete(Deck deck);
        Task Update(Deck deck);
    }
}