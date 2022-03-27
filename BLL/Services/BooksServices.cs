using SF_25.BLL.Models;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.QueryEntitys;
using SF_25.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.BLL.Services
{
    public class BooksServices
    {
        IBookRepository bookRepository;

        public BooksServices()
        {
            bookRepository = new BookRepository();
        }

        public List<BookModel> GetBooksSortedTitle()
        {
            return GetAllBooks().OrderBy(b => b.Title) as List<BookModel>;
        }

        public List<BookModel> GetBooksSortedYearPublDesc()
        {
            return GetAllBooks().OrderByDescending(b => b.Year_of_publication) as List<BookModel>;
        }

        private List<BookModel> GetAllBooks()
        {
            var query = bookRepository.GetAllBooks();

            var listBooks = new List<BookModel>();

            foreach (var book in query)
            {
                listBooks.Add(new BookModel
                {
                    Author = book.Author,
                    Genre = book.Genre,
                    Publishing_house = book.Publishing_house,
                    Title = book.Title,
                    Year_of_publication = book.Year_of_publication
                });
            }

            return listBooks;
        }

        public List<BookModel> GetBooksGenreBetweenYears(string genre_, int year_1, int year_2)
        {
            var query = bookRepository.GetBooksGenreBetweenYears(genre_, year_1, year_2);

            var listBooks = new List<BookModel>();

            foreach (var book in query)
            {
                listBooks.Add(new BookModel
                {
                    Author = book.Author,
                    Genre = book.Genre,
                    Publishing_house = book.Publishing_house,
                    Title = book.Title,
                    Year_of_publication = book.Year_of_publication
                });
            }

            return listBooks;
        }
    }
}
