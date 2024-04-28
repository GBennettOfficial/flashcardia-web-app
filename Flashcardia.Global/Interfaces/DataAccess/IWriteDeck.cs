

namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IWriteDeck
    {
        Task<ServiceResponse> Create(Deck deck);
        Task<ServiceResponse> Delete(Deck deck);
        Task<ServiceResponse> Update(Deck deck);
    }
}