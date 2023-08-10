using MeasurementsWebAPI.BusinessLogic.Models;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.DataAccess.Interfaces
{
    public interface IAtmRepository
    {
        Task<IEnumerable<Atm>> GetAll();        
        Task<Atm?> Get(int id);
        void Insert(Atm atm);
        void Update(Atm atm);
        void Delete(int id);
    }
}
