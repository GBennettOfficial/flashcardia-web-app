

namespace Flashcardia.Global.Interfaces.DataAccess
{
    public interface IDataAccessReader<TId, TObj>
         where TObj : class
    {
        Task<ServiceResponse<TObj>> Read(TId id);
    }
}