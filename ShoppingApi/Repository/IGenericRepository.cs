namespace ShoppingApi.Repository;

using ShoppingApi.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
       params Expression<Func<T, object>>[] includes);
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T obj);
    void Update(T obj);
    void Delete(int id);
    Task SaveAsync();
    //Task<T> GetByUserDate(int id, DateOnly period);
}