using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BooksView_1
    {
        BooksServices booksServices;

        public BooksView_1(BooksServices booksServices)
        {
            this.booksServices = booksServices;
        }

        public void Show()
        {
            Console.Write("Введите жанр: ");

            string genre = Console.ReadLine();

            int year_1, year_2;

            while (true)
            {
                Console.Write("Введите год от: ");

                if (int.TryParse(Console.ReadLine(), out year_1))
                    break;
                else
                    AlertMessage.Show("Неверный ввод. Вводите год по образцу: 2022");
            }

            while (true)
            {
                Console.Write("Введите год до: ");

                if (int.TryParse(Console.ReadLine(), out year_2))
                    break;
                else
                    AlertMessage.Show("Неверный ввод. Вводите год по образцу: 2022");
            }

            var books = booksServices.GetBooksGenreBetweenYears(genre, year_1, year_2);

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

            Console.Write("ДЛЯ ВЫХОДА НАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.booksView.Show();
        }
    }
}
