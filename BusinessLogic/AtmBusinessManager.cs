using MeasurementsWebAPI.BusinessLogic.Interfaces;
using MeasurementsWebAPI.BusinessLogic.Models;
using MeasurementsWebAPI.DataAccess.Interfaces;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.BusinessManager
{
    public class AtmBusinessManager : IAtmBusinessManager
    {
        private readonly IGenericRepository<Atm> _repository;
        //private readonly ILogger _logger;

        public AtmBusinessManager(IGenericRepository<Atm> repository)
        {
            _repository = repository;
            //_logger = logger;
        }

        public void Delete(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: Delete Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }

        public async Task<IEnumerable<Atm>> Get(Expression<Func<Atm, bool>> pred)
        {
            try
            {
                return await _repository.Get(pred);
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: Get Method!";
                //_logger.LogError(errorMessage, ex);
                return Enumerable.Empty<Atm>();
            }
        }

        public async Task<IEnumerable<Atm>> GetAll()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: GetAll Method!";
                //_logger.LogError(errorMessage, ex);
                return Enumerable.Empty<Atm>();
            }
        }

        public void Insert(Atm atm)
        {
            try
            {
                _repository.Insert(atm);
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: Insert Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }

        public async Task<Atm?> SingleOrDefault(Expression<Func<Atm, bool>> pred)
        {
            try
            {
                return await _repository.SingleOrDefault(pred);
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: SingleOrDefult Method!";
                //_logger.LogError(errorMessage, ex);
                return null;
            }
        }

        public void Update(Atm atm)
        {
            try
            {
                _repository.Update(atm);
            }
            catch (Exception ex)
            {
                var errorMessage = $"ATM Business Manager: Update Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }
    }
}
