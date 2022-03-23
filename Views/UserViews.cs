using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using SF_25.Entities;

namespace SF_25.Views
{
    public class UserViews
    {
        public void ViewAllUsers(IOrderedQueryable<User> usersQuery)
        {
            int numberPP = 1;

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
