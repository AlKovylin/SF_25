using SF_25.DAL.Repository;
using System;

namespace SF_25
{
    class Program
    {
        static UserRepository UR = new UserRepository();
        static BookRepository BR = new BookRepository();
       
        static void Main(string[] args)
        {
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



            //UR.GetAllUser();
            BR.GetAllBooks();
            BR.GetAllGenre();
        }
    }
}
