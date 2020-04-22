using LTI.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTI.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            //return DataSource().Where(x => x.Id == id).FirstOrDefault();
            BookModel bookModel = DataSource().Find(x => x.Id == id);
            return bookModel;
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="Mvc",Author="John"},
                new BookModel(){Id=1,Title="Java",Author="Mark"},
                new BookModel(){Id=1,Title=".Net",Author="Alex"},
                new BookModel(){Id=1,Title="Php",Author="Richard"},
                new BookModel(){Id=1,Title="Python",Author="James"},
            };
        }
    }
}
