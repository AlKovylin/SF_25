using SF_25.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.DAL.Repository
{
    public class BookRepository
    {
        public void GetAllBooks()
        {
            using (var db = new AppContext())
            {
                int numberPP = 1;

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

                Console.WriteLine("\t\tСПИСОК КНИГ");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("|№п/п|                  Автор                    |          Название          |        Жанр        |    Изд-во   |Год |");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                foreach (var book in booksQuery)
                {
                    Console.WriteLine("| {0, -2} | {1, -41} | {2, -26} | {3, -18} | {4, -11} |{5, -4}|",
                                        numberPP, book.Title, book.Author, book.Genre, book.PH, book.Year);

                    numberPP++;
                }

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }
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

        public List<UserEntity> GetAllUsers()
        {
            using (var db = new AppContext())
            {
                return db.Users.ToList();
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

        public void AddNewUser(UserEntity user)
        {
            using (var db = new AppContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteUser(UserEntity user)
        {
            using (var db = new AppContext())
            {
                db.Users.Remove(user);
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

        public void UpdatUser()
        {
            using (var db = new AppContext())
            {
               
            }
        }
    }
}
