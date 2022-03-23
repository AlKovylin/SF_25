using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.Entities
{
    public class Author
    {
        public int Id { get; set; }
        /// <summary>
        /// Полное имя.
        /// </summary>
        public string Full_name { get; set; }

        // Навигационное свойство
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
