namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IReadDecks
    {
        Task<ServiceResponse<ICollection<Deck>>> Get(string userId);
    }
}
