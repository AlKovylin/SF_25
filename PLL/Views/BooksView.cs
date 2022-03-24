using System.Collections.Generic;
using SF_25.DAL.Entities;
using System;

namespace SF_25.PLL.Views
{
    public class BooksView
    {
        public void Show(List<BookEntity> books)
        {
            int numberPP = 1;

            Console.WriteLine("\t\tСПИСОК КНИГ");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|№п/п|                  Автор                    |          Название          |        Жанр        |    Изд-во   |Год |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            foreach (var book in books)
            {
                Console.WriteLine("| {0, -2} | {1, -41} | {2, -26} | {3, -18} | {4, -11} |{5, -4}|",
                                  numberPP, book.Title, book.Author, book.Genre, book.Publishing_house, book.Year_of_publication);

                numberPP++;
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
