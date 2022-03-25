using System.Collections.Generic;
using System;
using SF_25.BLL.Models;
using SF_25.BLL.Services;

namespace SF_25.PLL.Views
{
    public class AllBooksView
    {
        BooksServices booksServices;

        public AllBooksView(BooksServices booksServices)
        {
            this.booksServices = booksServices;
        }

        public void Show()
        {
            var books = booksServices.GetAllBook();

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
