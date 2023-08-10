using MeasurementsWebAPI.BusinessLogic.Models;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.BusinessLogic.Interfaces
{
    public interface IAtmBusinessManager
    {
        Task<IEnumerable<Atm>> GetAll();
        Task<Atm?> SingleOrDefault(Expression<Func<Atm, bool>> pred);
        Task<IEnumerable<Atm>> Get(Expression<Func<Atm, bool>> pred);
        void Insert(Atm atm);
        void Update(Atm atm);
        void Delete(int id);
    }
}
