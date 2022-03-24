using System.Collections.Generic;
using SF_25.DAL.Entities;
using System;

namespace SF_25.Views
{
    public class UsersView
    {
        public void Show(List<UserEntity> users)
        {
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
