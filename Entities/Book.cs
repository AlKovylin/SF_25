using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.Entities
{
    public class Book
    {
        public int Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }        
        /// <summary>
        /// Год издания.
        /// </summary>
        public int Year_of_publication { get; set; }

        // Внешний ключ
        public int Publishing_houseId { get; set; }
        // Навигационное свойство
        public Publishing_house Publishing_house { get; set; }

        // Внешний ключ
        public int AuthorId { get; set; }
        // Навигационное свойство
        public Author Author { get; set; }

        // Внешний ключ
        public int GenreId { get; set; }
        // Навигационное свойство
        public Genre Genre { get; set; }

        // Навигационное свойство
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
