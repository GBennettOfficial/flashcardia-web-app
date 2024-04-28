namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IWriteCard
    {
        Task<ServiceResponse> Create(Card card);
        Task<ServiceResponse> Delete(Card card);
        Task<ServiceResponse> Update(Card card);
    }
}