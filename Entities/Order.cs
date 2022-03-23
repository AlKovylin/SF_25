using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.Entities
{
    public class Order
    {
        public int Id { get; set; }
        /// <summary>
        /// Дата выдачи.
        /// </summary>
        public DateTime Date_of_issue { get; set; }
        /// <summary>
        /// Дата возврата.
        /// </summary>
        public DateTime Return_date { get; set; }
        /// <summary>
        /// Отметка о возврате.
        /// </summary>
        public bool Flag_return { get; set; }


        // Внешний ключ
        public int UserId { get; set; }
        // Навигационное свойство
        public User User { get; set; }

        // Внешний ключ
        public int BookId { get; set; }
        // Навигационное свойство
        public Book Book { get; set; }
    }
}
