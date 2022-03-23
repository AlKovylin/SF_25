using SF_25.Entities;

namespace SF_25.DataForDB_
{
    public class UsresData
    {
        public User User1 = new User { FirstName = "Андрей", LastName = "Попов", Email = "andreq@mail.ru", Phone = "+7(999)232-55-85" };
        public User User2 = new User { FirstName = "Василий", LastName = "Егоров", Email = "vasil@mail.ru", Phone = "+7(989)113-52-25" };
        public User User3 = new User { FirstName = "Сергей", LastName = "Николаев", Email = "sergey@ya.ru", Phone = "+7(989)362-78-83" };
        public User User4 = new User { FirstName = "Светлана", LastName = "Мурашкина", Email = "cveta@mail.ru", Phone = "+7(979)421-57-81" };
        public User User5 = new User { FirstName = "Юрий", LastName = "Никонов", Email = "yura@ya.ru", Phone = "+7(999)477-12-43" };
        public User User6 = new User { FirstName = "Марина", LastName = "Рогова", Email = "marina@mail.ru", Phone = "+7(979)211-14-85" };
        public User User7 = new User { FirstName = "Татьяна", LastName = "Григорьева", Email = "tanj@ya.ru", Phone = "+7(999)521-89-98" };
        public User User8 = new User { FirstName = "Горгий", LastName = "Шмелёв", Email = "goga@ya.ru", Phone = "+7(989)852-96-74" };
        public User User9 = new User { FirstName = "Вячеслав", LastName = "Майоров", Email = "slsva@mail.ru", Phone = "+7(999)789-23-54" };
        public User User10 = new User { FirstName = "Роман", LastName = "Козицин", Email = "roma@ya.ru", Phone = "+7(999)526-91-73" };

        public void Record(AppContext db)
        {
            db.AddRange(User1, User2, User3, User4, User5, User6, User7, User8, User9, User10);
            db.SaveChanges();
        }
    }
}
