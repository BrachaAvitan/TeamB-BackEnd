using App.DA.DataContext;
using App.DA.Entities;
using App.DA.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.DA.Reposetoris
{
    public class BookRepository : IBookRepository
    {
        private readonly BooksContext _db;

        public BookRepository(BooksContext dbBooks)
        {
            _db = dbBooks;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _db.Books.ToListAsync();
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            book.bookId = Guid.NewGuid();
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task<Book> GetBookByIdAsync(Guid BookId)
        {
            return await _db.Books.SingleOrDefaultAsync(b => b.bookId == BookId);
        }

        public async Task<Book> UpdateBookAsync(Book book)
        {
            _db.Books.Entry(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return book;
        }

        public async Task DeleteBookAsync(Guid BookId)
        {
            var bookToDelete = await _db.Books.SingleOrDefaultAsync(b => b.bookId == BookId);
            if (bookToDelete != null)
            {
                _db.Books.Remove(bookToDelete);
                await _db.SaveChangesAsync();
            }
        }
    }
}
