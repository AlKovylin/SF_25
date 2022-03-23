using SF_25.Entities;

namespace SF_25.DataForDB_
{
    public class AuthorsData
    {
        public Author Author1 = new Author { Full_name = "Джордж Оруэлл" };
        public Author Author2 = new Author { Full_name = "Айзек Азимов" };
        public Author Author3 = new Author { Full_name = "Сергей Снегов" };
        public Author Author4 = new Author { Full_name = "Артур Кларк" };
        public Author Author5 = new Author { Full_name = "Аркадий и Борис Стругацкие" };
        public Author Author6 = new Author { Full_name = "Иван Антонович Ефремов" };
        public Author Author7 = new Author { Full_name = "Артур Конан Дойл" };
        public Author Author8 = new Author { Full_name = "Марк Твен" };
        public Author Author9 = new Author { Full_name = "Жюль Верн" };
        public Author Author10 = new Author { Full_name = "Борис Акунин" };
        public Author Author11 = new Author { Full_name = "Роберт ван Гулик" };

        public void Record(AppContext db)
        {            
            db.Authors.AddRange(Author1, Author2, Author3, Author4, Author5, Author6, Author7,
                                Author8, Author9, Author10, Author11);
            db.SaveChanges();
        }
    }
}
