using App.DA.Entities;
using App.DA.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookDTO> CreateBookAsync(BookDTO book)
        {
            book.bookId = Guid.NewGuid();
            var createBook = await _bookRepository.CreateBookAsync(_mapper.Map<Book>(book));
            return _mapper.Map<BookDTO>(createBook);
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            return await _bookRepository.CreateBookAsync(book);
        }

        public async Task DeleteBookAsync(Guid BookId)
        {
            await _bookRepository.DeleteBookAsync(BookId);
        }

        public async Task<Book> GetBookByIdAsync(Guid BookId)
        {
            return await _bookRepository.GetBookByIdAsync(BookId);
        }

        public async Task<List<BookDTO>> GetBooksAsync()
        {
            var bookList = await _bookRepository.GetBooksAsync();
            return _mapper.Map<List<BookDTO>>(bookList);
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            return await _bookRepository.UpdateBookAsync(book);
        }
    }
}
