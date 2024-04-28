namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IWriteCard
    {
        Task Create(Card card);
        Task Delete(Card card);
        Task Update(Card card);
    }
}