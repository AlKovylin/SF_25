using System.Collections.Generic;
using SF_25.DAL.Entitys;
using System;
using SF_25.BLL.Services;

namespace SF_25.PLL.Views
{
    public class UsersView
    {
        UsersServices usersServices;

        public UsersView(UsersServices usersServices)
        {
            this.usersServices = usersServices;
        }

        public void Show()
        {
            var users = usersServices.GetAllUsers();

            int numberPP = 1;

            Console.WriteLine("\t\tСПИСОК АБОНЕНТОВ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|№п/п|          ФИО           |     Телефон      |      Почта      |");
            Console.WriteLine("--------------------------------------------------------------------");

            foreach (var user in users)
            {
                Console.WriteLine("| {0, -2} | {1, -10} {2, -12}| {3, -12} | {4, -16}|", 
                                  numberPP, user.FirstName, user.LastName, user.Phone, user.Email);
                numberPP++;
            }

            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
