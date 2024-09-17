using App.DA.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.DA.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDTO>> GetBooksAsync();
        Task<BookDTO> CreateBookAsync(BookDTO book);
        Task<Book> GetBookByIdAsync(Guid BookId);
        Task<Book> UpdateBookAsync(Book book);
        Task DeleteBookAsync(Guid BookId);
    }
}
