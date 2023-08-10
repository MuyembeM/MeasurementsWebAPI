using MeasurementsWebAPI.BusinessLogic.Models;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.BusinessLogic.Interfaces
{
    public interface IUserBusinessManager
    {
        Task<User?> SingleOrDefault(Expression<Func<User, bool>> pred);
    }
}
