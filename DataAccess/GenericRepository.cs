using MeasurementsWebAPI.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MeasurementsDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        //private readonly ILogger _logger;

        public GenericRepository(MeasurementsDBContext dBContext)
        {
            _dbContext = dBContext;
            _dbSet = dBContext.Set<T>();
        }
        
        public void Delete(object id)
        {
            try
            {
                var entityToDelete = _dbSet.Find(id);
                if (entityToDelete != null)
                {
                    Delete(entityToDelete);
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }catch(Exception ex)
            {
                var errorMessage = $"Generic Repository: Delete Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
        {
            try { 
                return await _dbSet.Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                var errorMessage = $"Generic Repository: Get Method!";
                //_logger.LogError(errorMessage, ex);

                return Enumerable.Empty<T>();
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try { 
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                var errorMessage = $"Generic Repository: GetAll Method!";
                //_logger.LogError(errorMessage, ex);
                return Enumerable.Empty<T>();
            }
        }

        public void Insert(T entity)
        {
            try
            {
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                var errorMessage = $"Generic Repository: Insert Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }

        public async Task<T?> SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _dbSet.Where(predicate).SingleOrDefaultAsync();
            }
            catch (Exception ex)
            {
                var errorMessage = $"Generic Repository: SingleOrDefault Method!";
                //_logger.LogError(errorMessage, ex);
                return null;
            }
        }

        public void Update(T entityToUpdate)
        {
            try
            {
                _dbSet.Attach(entityToUpdate);
                _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                var errorMessage = $"Generic Repository: Update Method!";
                //_logger.LogError(errorMessage, ex);
            }
        }
    }
}
