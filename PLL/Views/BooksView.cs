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

                string command = KeyReader.KeyRead();

                if (command.Contains("End"))
                    break;

                if (int.TryParse(command, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {
                                Program.booksView_1.Show();
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Введите полное имя автора: ");
                                string fullName = Console.ReadLine();
                                Console.WriteLine("Количество книг автора {1} составляет: {0} наименований.",
                                                   booksServices.NumberBooksTheAuthor(fullName), fullName);
                                break;
                            }

                        case 3:
                            {
                                Console.Write("Введите название жанра: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Количество книг жанра {1} составляет: {0} наименований.",
                                                   booksServices.NumberBooksTheGenre(name), name);
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Введите полное имя автора: ");
                                string fullName = Console.ReadLine();

                                Console.Write("Введите название книги: ");
                                string title = Console.ReadLine();

                                if (booksServices.СheckAuthorAndTitleBook(fullName, title))
                                    Console.WriteLine("Есть такая книга.");
                                else
                                    Console.WriteLine("Нет такой книги.");

                                break;
                            }
                        case 5:
                            {
                                Console.Write("Введите название книги: ");
                                string title = Console.ReadLine();

                                if (!booksServices.СheckBook(title))
                                {
                                    Console.WriteLine("Указанная книга в библиотеке отсутствует.");

                                    break;
                                }

                                if (booksServices.СheckBookInOrder(title))
                                {
                                    var userName = booksServices.GetNameUserOrderedTheBook(title);
                                    Console.Write($"Эта книга на руках у абонента:  {userName}");
                                }
                                else
                                {
                                    Console.WriteLine("Данная книга доступна к выдаче.");
                                }

                                break;
                            }
                        case 6:
                            {
                                Console.Write("Введите имя абонента: ");
                                string firstName = Console.ReadLine();

                                Console.Write("Введите фамилию абонента: ");
                                string lastName = Console.ReadLine();

                                if (booksServices.CheckUser(firstName, lastName))
                                {
                                    var number = booksServices.NumberBooksTheUserHas(firstName, lastName);

                                    Console.WriteLine($"Количество книг на руках у абонента {firstName} {lastName} равно {number}.");
                                }
                                else
                                {
                                    Console.WriteLine("Пользователь не зарегистрирован.");
                                }

                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Получена команда 7");
                                break;
                            }
                        case 8:
                            {
                                Program.allBooksView.Show(booksServices.GetBooksSortedTitle());
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
