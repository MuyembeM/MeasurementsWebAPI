using System.Linq.Expressions;

namespace MeasurementsWebAPI.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> SingleOrDefault(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
    }
}
