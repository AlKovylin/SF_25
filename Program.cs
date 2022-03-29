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

        public static RootMenuView rootMenuView;

        public static BooksViewMenu booksViewMenu;
        public static BooksViewTable booksViewTable;
        public static BooksView_1 booksView_1;
        public static BooksView_2 booksView_2;
        public static BooksView_3 booksView_3;
        public static BooksView_4 booksView_4;
        public static BooksView_5 booksView_5;
        public static BooksView_6 booksView_6;

        public static UsersMenuView usersMenuView;
        

        static void Main(string[] args)
        {
            Console.SetWindowSize(140, 40);

            booksServices = new BooksServices();
            usersServices = new UsersServices();

            rootMenuView = new RootMenuView();

            booksViewMenu = new BooksViewMenu(booksServices);
            booksViewTable = new BooksViewTable();
            booksView_1 = new BooksView_1(booksServices);
            booksView_2 = new BooksView_2(booksServices);
            booksView_3 = new BooksView_3(booksServices);
            booksView_4 = new BooksView_4(booksServices);
            booksView_5 = new BooksView_5(booksServices);
            booksView_6 = new BooksView_6(booksServices);

            usersMenuView = new UsersMenuView(usersServices);
                                   
            rootMenuView.Show();
        }
    }
}
