

namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IDataAccessWriter<T>
        where T : class
    {
        Task<ServiceResponse> Create(T obj);
        Task<ServiceResponse> Delete(T obj);
        Task<ServiceResponse> Update(T obj);
    }
}