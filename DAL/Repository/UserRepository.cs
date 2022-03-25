using SF_25.DAL.Entitys;
using SF_25.DAL.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF_25.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public void GetAllUser()
        {
            using (var db = new AppContext())
            {
                int numberPP = 1;

                var usersQuery = db.Users.OrderBy(u => u.LastName).ToList();

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

        public List<UserEntity> GetAllUsers()
        {
            using (var db = new AppContext())
            {
                return db.Users.ToList();
            }
        }

        public void AddNewUser(UserEntity user)
        {
            using (var db = new AppContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteUser(UserEntity user)
        {
            using (var db = new AppContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public void UpdatUser()
        {
            using (var db = new AppContext())
            {

            }
        }
    }
}
