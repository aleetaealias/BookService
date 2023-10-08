using BookService.Data;
using BookService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookService.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        // POST /api/book/create
        [HttpPost("create")]
        public int Create(Book book)
        {
            if(book is not null)
            {
                book.RegistrationTimeStamp = DateTime.Now;
                var addedBook = _db.Books.Add(book);
                _db.SaveChanges();
                return addedBook.Entity.Id;
            }
            return 0;
        }

  
        // PUT /api/book/{bookId}/update
        [HttpPut("{bookid}/update")]
        public int Update(int bookid, Book book)
        {
            Book bookItem = _db.Books.Where(x => x.Id == bookid).FirstOrDefault();
            if(bookItem is not null)
            {
                bookItem.Author = string.IsNullOrEmpty(book.Author) ? bookItem.Author : book.Author;
                bookItem.Name = string.IsNullOrEmpty(book.Name) ? bookItem.Name : book.Name;
                bookItem.Category = string.IsNullOrEmpty(book.Category) ? bookItem.Category : book.Category;
                bookItem.Description = string.IsNullOrEmpty(book.Description) ? bookItem.Description : book.Description;

                var updatedBook = _db.Books.Update(bookItem);
                _db.SaveChanges();
                return updatedBook.Entity.Id;
            }
            return 0;
        }
    }
}