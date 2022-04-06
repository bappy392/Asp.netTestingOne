using FirstMVCCoreApp1.Models;

namespace FirstMVCCoreApp1.Repository
{
    public class BookRepository
    {
         public List<BookModel> GetAllBooks()
        {
            return DataSrouce();

        }
        public BookModel GetBookById(int id)
        {
            return DataSrouce().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSrouce().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSrouce()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC1", Author ="Khan1", Description="This is the description for MVC1 Book"},
                new BookModel(){Id=2, Title="MVC2", Author ="Khan2", Description="This is the description for MVC2 Book"},
                new BookModel(){Id=3, Title="MVC3", Author ="Khan3", Description="This is the description for MVC3 Book"},
                new BookModel(){Id=4, Title="MVC4", Author ="Khan4", Description="This is the description for MVC4 Book"},
                new BookModel(){Id=5, Title="MVC5", Author ="Khan5", Description="This is the description for MVC5 Book"},
            };
        }
    }
}
