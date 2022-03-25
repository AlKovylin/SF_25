using SF_25.BLL.Services;
using SF_25.DAL.Repository;
using SF_25.PLL;
using SF_25.PLL.Views;
using System;

namespace SF_25
{
    class Program
    {
        static BooksServices booksServices;
        static UsersServices usersServices;
        static KeyReder keyReder;
        public static BookView bookView;
        public static AllBooksView allBooksView;
        public static UsersView usersView;
        

        static void Main(string[] args)
        {
            booksServices = new BooksServices();
            usersServices = new UsersServices();
            keyReder = new KeyReder();
            bookView = new BookView();
            allBooksView = new AllBooksView(booksServices);
            usersView = new UsersView(usersServices);


            using (var db = new DAL.AppContext())
            {
                //db.DeletedDB();
                //if (!db.Exists())
                //{
                //    db.CreatedDB();
                //    var AddData = new AddDataInDB();
                //    AddData.AddData(db);
                //}
            }

            Console.WriteLine("Размер консоли: {0}x{1}.", Console.WindowWidth, Console.WindowHeight);

            Console.SetWindowSize(140, 40);

            Console.WriteLine("Размер консоли: {0}x{1}.", Console.WindowWidth, Console.WindowHeight);

            //allBooksView.Show();
            //usersView.Show();

            bookView.Show(keyReder);
        }
    }
}
