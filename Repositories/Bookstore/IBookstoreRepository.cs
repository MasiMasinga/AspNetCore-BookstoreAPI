using BookstoreAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookstoreAPI.Repositories
{
    public interface IBookstoreRepository
    {
        Task<List<Bookstore>> GetAllAsync();
        Task<Bookstore?> GetByIdAsync(int id);
        Task<Bookstore> CreateAsync(Bookstore bookstore);
        Task<bool> UpdateAsync(Bookstore bookstore);
        Task<bool> DeleteAsync(int id);
    }
}
