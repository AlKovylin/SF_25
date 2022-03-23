using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.Repository
{
    public class UserRepository
    {
        public void GetAllUser()
        {
            using (var db = new AppContext())
            {
                int numberPP = 1;

                var usersQuery = db.Users.OrderBy(u => u.LastName);

                Console.WriteLine("\t\tСПИСОК АБОНЕНТОВ");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("|№п/п|          ФИО           |     Телефон      |      Почта      |");
                Console.WriteLine("--------------------------------------------------------------------");

                foreach (var user in usersQuery)
                {
                    Console.WriteLine("| {0, -2} | {1, -10} {2, -12}| {3, -12} | {4, -16}|", numberPP, user.FirstName, user.LastName, user.Phone, user.Email);
                    numberPP++;
                }

                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}
