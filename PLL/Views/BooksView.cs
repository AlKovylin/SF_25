using System;
using System.Collections.Generic;
using System.Text;
using SF_25.BLL.Services;
using SF_25.PLL.Views.Helpers;

namespace SF_25.PLL.Views
{
    public class BooksView
    {
        BooksServices booksServices;

        public BooksView(BooksServices booksServices)
        {
            this.booksServices = booksServices;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("|                                     КНИГИ                                      |");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("1. Получать список книг определенного жанра и вышедших между определенными годами.");
                Console.WriteLine("2. Получать количество книг определенного автора в библиотеке.");
                Console.WriteLine("3. Получать количество книг определенного жанра в библиотеке.");
                Console.WriteLine("4. Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке.");
                Console.WriteLine("5. Получать булевый флаг о том, есть ли определенная книга на руках у пользователя.");
                Console.WriteLine("6. Получать количество книг на руках у пользователя.");
                Console.WriteLine("7. Получение последней вышедшей книги.");
                Console.WriteLine("8. Получение списка всех книг, отсортированного в алфавитном порядке по названию.");
                Console.WriteLine("9. Получение списка всех книг, отсортированного в порядке убывания года их выхода.");
                Console.WriteLine("\nВВЕДИТЕ ЦИФРУ ПУНКТА МЕНЮ ИЛИ НАЖМИТЕ \"END\" ДЛЯ ВЫХОДА В ГЛАНОЕ МЕНЮ.");

                string command = KeyReder.KeyRead();

                if (command.Contains("End"))
                    break;

                if (int.TryParse(command, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {
                                Program.booksView_1.Show();
                                //Console.WriteLine("Получена команда 1");
                                break;
                            }
                        case 2:
                            {                                
                                Console.WriteLine("Получена команда 2");
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Получена команда 3");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Получена команда 4");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Получена команда 5");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Получена команда 6");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Получена команда 7");
                                break;
                            }
                        case 8:
                            {
                                var listBooks = booksServices.GetBooksSortedTitle();
                                Program.allBooksView.Show(listBooks);
                                break;
                            }
                        case 9:
                            {
                                Program.allBooksView.Show(booksServices.GetBooksSortedYearPublDesc());
                                break;
                            }
                        default:
                            {
                                AlertMessage.Show("Неизвестная команда");
                                break;
                            }
                    }
                }
                else
                {
                    AlertMessage.Show("Неизвестная команда");
                }
            }
        }
    }
}
