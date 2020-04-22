using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTI.BookStore.Models;
using LTI.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LTI.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //http//localhost:55540/Book/GetAllBooks
        //public string GetAllBooks()
        public List<BookModel> GetAllBooks()
        {
            //return "All Books";
            return _bookRepository.GetAllBooks();
        }

        //http//localhost:55540/Book/GetBook/1
        //public string GetBook(int id)
        public BookModel GetBook(int id)
        {
            //return $"Book with id= {id}";
            return _bookRepository.GetBookById(id);
        }


        //http//localhost:55540/Book/searchbooks?bookname=MvcBook&authorname=John
        //public string SearchBooks(string bookName,string authorName)
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            //return $"Book with name= {bookName} & Author= {authorName}";
            return _bookRepository.SearchBook(bookName, authorName);
        }


    }
}