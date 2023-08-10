using MeasurementsWebAPI.BusinessLogic.Interfaces;
using MeasurementsWebAPI.BusinessLogic.Models;
using MeasurementsWebAPI.DataAccess.Interfaces;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.BusinessManager
{
    public class UserBusinessManager : IUserBusinessManager
    {
        private readonly IGenericRepository<User> _repository;

        public UserBusinessManager(IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<User?> SingleOrDefault(Expression<Func<User, bool>> pred)
        {
            return await _repository.SingleOrDefault(pred);
        }
    }
}
