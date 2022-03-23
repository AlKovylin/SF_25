using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        /// <summary>
        /// Название жанра.
        /// </summary>
        public string Name { get; set; }

        // Навигационное свойство
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
