using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class BookView
    {
        public void Show(KeyReder keyReder)
        {
            while (true)
            {
                Console.WriteLine("1. Получать список книг определенного жанра и вышедших между определенными годами.");
                Console.WriteLine("2. Получать количество книг определенного автора в библиотеке.");
                Console.WriteLine("3. Получать количество книг определенного жанра в библиотеке.");
                Console.WriteLine("4. Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке.");
                Console.WriteLine("5. Получать булевый флаг о том, есть ли определенная книга на руках у пользователя.");
                Console.WriteLine("6. Получать количество книг на руках у пользователя.");
                Console.WriteLine("7. Получение последней вышедшей книги.");
                Console.WriteLine("8. Получение списка всех книг, отсортированного в алфавитном порядке по названию.");
                Console.WriteLine("9. Получение списка всех книг, отсортированного в порядке убывания года их выхода.");
                Console.WriteLine("\nВВЕДИТЕ ЦИФРУ ПУНКТА МЕНЮ ИЛИ НАЖМИТЕ \"END\" ДЛЯ ВЫХОДА.");

                string command = keyReder.KeyRed();

                Console.WriteLine("Получена неизвестная команда" + command);

                if (command.Contains("End"))
                    break;
                /*switch (int.Parse(command))
                {
                    case 1:
                        {
                            Console.WriteLine("Получена команда 1");
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
                    default:
                        {
                            Console.WriteLine("Получена неизвестная команда" + command);
                            break;
                        }
                }*/
            }
        }
    }
}
