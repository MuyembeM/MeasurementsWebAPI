using MeasurementsWebAPI.BusinessLogic;
using MeasurementsWebAPI.BusinessLogic.Interfaces;
using MeasurementsWebAPI.BusinessLogic.Models;
using MeasurementsWebAPI.DataAccess.Interfaces;
using System.Linq.Expressions;


namespace MeasurementsWebAPI.BusinessManager
{
    public class AtmBusinessManager : IAtmBusinessManager
    {
        private readonly IAtmRepository _repository;
        
        public AtmBusinessManager(IAtmRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Atm?> Get(int id)
        {
            try
            {
                return await _repository.Get(id);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<IEnumerable<Atm>> GetAll()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Atm atm)
        {
            try
            {
                _repository.Insert(atm);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Atm atm)
        {
            try
            {
                _repository.Update(atm);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
