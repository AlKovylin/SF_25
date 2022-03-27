using SF_25.BLL.Exeption;
using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using SF_25.DAL.QueryEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.DAL.Repository
{
    public class BookRepository : IBookRepository
    {
        /*public List<BookQueryEntity> GetBooksSortedTitle()
        {
            var AllBook = new List<BookQueryEntity>();

            var booksQuery = GetAllBooks().OrderBy(b => b.Title).ToList();

            foreach (var book in booksQuery)
            {
                AllBook.Add(book);
            }

            return AllBook;
        }
        public List<BookQueryEntity> GetBooksSortedYearPublDesc()
        {
            var AllBook = new List<BookQueryEntity>();

            var booksQuery = GetAllBooks().OrderBy(b => b.Year_of_publication).ToList();

            foreach (var book in booksQuery)
            {
                AllBook.Add(book);
            }

            return AllBook;
        }

        private IQueryable<BookQueryEntity> GetAllBooks()
        {
            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  select new BookQueryEntity
                                  {
                                      Title = book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      Publishing_house = p.Name,
                                      Year_of_publication = book.Year_of_publication.ToString()
                                  });

                return booksQuery;
            }
        }*/

        public List<BookQueryEntity> GetAllBooks()
        {
            var AllBook = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  select new BookQueryEntity
                                  {
                                      Title = book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      Publishing_house = p.Name,
                                      Year_of_publication = book.Year_of_publication.ToString()
                                  }).ToList();

                foreach (var book in booksQuery)
                {
                    AllBook.Add(book);
                }                
            }
            return AllBook;
        }


        public List<GenreEntity> GetAllGenres()
        {
            using (var db = new AppContext())
            {
                return db.Genres.ToList();
            }
        }

        public List<AuthorEntity> GetAllAuthors()
        {
            using (var db = new AppContext())
            {
                return db.Authors.ToList();
            }
        }

        public List<Publishing_houseEntity> GetAllPublishing_houses()
        {
            using (var db = new AppContext())
            {
                return db.Publishing_houses.ToList();
            }
        }

        public void AddNewBook(BookEntity book)
        {
            using (var db = new AppContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public void AddNewAuthor(AuthorEntity author)
        {
            using (var db = new AppContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
        }

        public void AddNewGenre(GenreEntity genre)
        {
            using (var db = new AppContext())
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }
        }

        public void AddNewPublishing_house(Publishing_houseEntity publishing_house)
        {
            using (var db = new AppContext())
            {
                db.Publishing_houses.Add(publishing_house);
                db.SaveChanges();
            }
        }

        public void DeleteBook(BookEntity book)
        {
            using (var db = new AppContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        public List<BookQueryEntity> GetBooksGenreBetweenYears(string genre_, int year_1, int year_2)
        {
            if (!СheckGenre(genre_))
                throw new ArgumentException();

            if (!(year_1 < year_2))
                throw new BetweenYearsException();

            var Books = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  where genre.Name == genre_
                                  where book.Year_of_publication >= year_1
                                  where book.Year_of_publication <= year_2
                                  select new BookQueryEntity
                                  {
                                      Title = book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      Publishing_house = p.Name,
                                      Year_of_publication = book.Year_of_publication.ToString()
                                  })
                                  .OrderBy(b => b.Year_of_publication)
                                  .ToList();

                foreach (var book in booksQuery)
                {
                    Books.Add(book);
                }
            }
            return Books;
        }

        public bool СheckGenre(string genre)
        {
            List<GenreEntity> genres = GetAllGenres();

            foreach (var gen in genres)
            {
                if (gen.Name == genre)
                    return true;
            }

            return false;
        }
    }
}
