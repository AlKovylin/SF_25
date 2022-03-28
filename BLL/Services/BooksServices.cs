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
            return ConstructListBook(GetAllBooks().OrderBy(b => b.Title));
        }

        public List<BookModel> GetBooksSortedYearPublDesc()
        {
            return ConstructListBook(GetAllBooks().OrderByDescending(b => b.Year_of_publication));
        }

        private List<BookModel> ConstructListBook(IOrderedEnumerable<BookModel> temp)
        {
            var listBooks = new List<BookModel>();

            foreach(var book in temp)
            {
                listBooks.Add(book);
            }

            return listBooks;
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

        public int NumberBooksTheAuthor(string fullName)
        {
            return bookRepository.NumberBooksTheAuthor(fullName);
        }

        public int NumberBooksTheGenre(string name)
        {
            return bookRepository.NumberBooksTheGenre(name);
        }

        public bool СheckAuthorAndTitleBook(string autorFullName, string titleBook)
        {
            return bookRepository.СheckAuthorAndTitleBook(autorFullName, titleBook);
        }

        public bool СheckBookInOrder(string titleBook)
        {
            return bookRepository.СheckBookInOrder(titleBook);
        }

        public string GetNameUserOrderedTheBook(string titleBook)
        {
            return bookRepository.GetNameUserOrderedTheBook(titleBook);
        }

        public bool СheckBook(string title)
        {
            return bookRepository.СheckBook(title);
        }

        public int NumberBooksTheUserHas(string firstName, string lastName)
        {
            return bookRepository.NumberBooksTheUserHas(firstName, lastName);
        }

        public bool CheckUser(string firstName, string lastName)
        {
            return bookRepository.CheckUser(firstName, lastName);
        }
    }
}
