using Microsoft.AspNetCore.Mvc;
using BookstoreAPI.Models;
using BookstoreAPI.Services;
using BookstoreAPI.DTOs;

[ApiController]
[Route("api/[controller]")]
public class BookstoreController : ControllerBase
{
    private readonly BookstoreService _service;

    public BookstoreController(BookstoreService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<Bookstore>> Create(CreateBookstoreDto dto)
    {

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateBookstoreDto dto)
    {
    }

    [HttpGet]
    public async Task<ActionResult<List<Bookstore>>> GetAll()
    {

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Bookstore>> GetById(int id)
    {

    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {

    }

}