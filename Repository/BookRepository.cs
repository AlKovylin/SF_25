using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.Repository
{
    public class BookRepository
    {
        public void GetAllBooks()
        {
            using (var db = new AppContext())
            {
                int numberPP = 1;

                var booksQuery = from book in db.Books
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
                                 };

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
    }
}
