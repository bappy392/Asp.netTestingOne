using FirstMVCCoreApp1.Models;
using FirstMVCCoreApp1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCCoreApp1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository=null;
        public BookController()
        {
            bookRepository = new BookRepository();

        }
        public ViewResult GetAllBooks()
        {
            var data= bookRepository.GetAllBooks();

            return View(data);
        }

        public BookModel GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }

       /* http://localhost:50214/book/SearchBooks?bookname=java&authorname=jamesGoosling
       query string*/
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
