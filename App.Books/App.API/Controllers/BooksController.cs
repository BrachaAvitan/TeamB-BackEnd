using App.API.Models;
using App.BL.Services;
using App.DA.Entities;
using App.DA.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BooksController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<BookDTO>> CreateBook([FromBody] CreateBookRequest book)
        {
            var bookDto = _mapper.Map<BookDTO>(book);
            var createdBook = await _bookService.CreateBookAsync(bookDto);
            return Ok(createdBook);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(Guid id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateBook([FromBody] Book book)
        {
            var updatedBook = await _bookService.UpdateBookAsync(book);
            if (updatedBook == null)
                return NotFound();
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(Guid id)
        {
            var bookToDelete = await _bookService.GetBookByIdAsync(id);
            if (bookToDelete == null)
                return NotFound();

            await _bookService.DeleteBookAsync(id);
            return NoContent();
        }
    }
}
