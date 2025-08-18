using Microsoft.EntityFrameworkCore;
using BookstoreAPI.Models;
using BookstoreAPI.DTOs;
using BookstoreAPI.Repositories;

namespace BookstoreAPI.Repositories
{
    public class BookstoreRepository : IBookstoreRepository
    {
        private readonly IBookstoreRepository _repository;

        public BookstoreRepository(IBookstoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Bookstore>> GetAllAsync()
        {
        }

        public async Task<Bookstore?> GetByIdAsync(int id)
        {
        }

        public async Task<Bookstore> CreateAsync(Bookstore bookstore)
        {
        }

        public async Task<bool> UpdateAsync(Bookstore bookstore)
        {
        }

        public async Task<bool> DeleteAsync(int id)
        {
        }
    }
}
