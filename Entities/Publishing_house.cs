using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.Entities
{
    public class Publishing_house
    {
        public int Id { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }    

        // Навигационное свойство
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
