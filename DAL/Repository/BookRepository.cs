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
        public List<BookQueryEntity> GetAllBooks()
        {
            var AllBook = new List<BookQueryEntity>();

            using (var db = new AppContext())
            {
                var booksQuery = (from book in db.Books
                                  join author in db.Authors on book.AuthorId equals author.Id
                                  join genre in db.Genres on book.GenreId equals genre.Id
                                  join p in db.Publishing_houses on book.Publishing_houseId equals p.Id
                                  select new
                                  {
                                      book.Title,
                                      Author = author.Full_name,
                                      Genre = genre.Name,
                                      PH = p.Name,
                                      Year = book.Year_of_publication
                                  }).ToList();

                foreach (var book in booksQuery)
                {
                    AllBook.Add(new BookQueryEntity
                    {
                        Title = book.Title,
                        Author = book.Author,
                        Genre = book.Genre,
                        Publishing_house = book.PH,
                        Year_of_publication = book.Year.ToString()
                    });
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
    }
}
