using BookstoreAPI.Models;
using BookstoreAPI.DTOs;
using BookstoreAPI.Repositories;

namespace BookstoreAPI.Services
{
    public class RecipeService
    {
        private readonly IBookstoreRepository _repository;

        public BookstoreService(IBookstoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Bookstore>> GetAllBooksAsync()
        {
        }

        public async Task<Recipe?> GetBookByIdAsync(int id)
        {
        }

        public async Task<Recipe> CreateBookAsync(CreateBookstore dto)
        {
        }

        public async Task<bool> UpdateBookAsync(int id, UpdateBookstore dto)
        {
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
        }
    }
}
