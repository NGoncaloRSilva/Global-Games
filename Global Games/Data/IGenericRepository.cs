using Global_Games.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Global_Games.Data
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();

        Task<T> GetByEmailAsync(string email);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(string email);
    }
}
