namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IReadDecks
    {
        Task<ICollection<Deck>> Get(string userId);
    }
}
