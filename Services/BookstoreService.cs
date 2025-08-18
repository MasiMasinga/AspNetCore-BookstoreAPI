using BookstoreAPI.Models;
using BookstoreAPI.DTOs;
using BookstoreAPI.Repositories;

namespace BookstoreAPI.Services
{
    public class BookstoreService
    {
        private readonly IBookstoreRepository _repository;

        public BookstoreService(IBookstoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Bookstore>> GetAllBooksAsync()
        {
        }

        public async Task<Bookstore?> GetBookByIdAsync(int id)
        {
        }

        public async Task<Bookstore> CreateBookAsync(CreateBookstoreDto dto)
        {
        }

        public async Task<bool> UpdateBookAsync(int id, UpdateBookstoreDto dto)
        {
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
        }
    }
}
