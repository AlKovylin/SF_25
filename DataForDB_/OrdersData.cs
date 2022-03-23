using SF_25.Entities;
using System;

namespace SF_25.DataForDB_
{
    public class OrderData
    {
        public Order Order1 = new Order { BookId = 1, UserId = 1, Date_of_issue = new DateTime(2021, 01, 10), Return_date = new DateTime(2021, 01, 20), Flag_return = true };
        public Order Order2 = new Order { BookId = 2, UserId = 10, Date_of_issue = new DateTime(2021, 01, 11), Return_date = new DateTime(2021, 01, 21), Flag_return = true };
        public Order Order3 = new Order { BookId = 3, UserId = 2, Date_of_issue = new DateTime(2021, 01, 11), Return_date = new DateTime(2021, 01, 21), Flag_return = true };
        public Order Order4 = new Order { BookId = 11, UserId = 9, Date_of_issue = new DateTime(2021, 01, 14), Return_date = new DateTime(2021, 01, 24), Flag_return = true };
        public Order Order5 = new Order { BookId = 5, UserId = 5, Date_of_issue = new DateTime(2021, 01, 15), Return_date = new DateTime(2021, 01, 25), Flag_return = true };
        public Order Order6 = new Order { BookId = 6, UserId = 4, Date_of_issue = new DateTime(2021, 01, 16), Return_date = new DateTime(2021, 01, 26), Flag_return = true };
        public Order Order7 = new Order { BookId = 7, UserId = 3, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public Order Order8 = new Order { BookId = 8, UserId = 1, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public Order Order9 = new Order { BookId = 9, UserId = 2, Date_of_issue = new DateTime(2021, 01, 17), Return_date = new DateTime(2021, 01, 27), Flag_return = true };
        public Order Order10 = new Order { BookId = 10, UserId = 6, Date_of_issue = new DateTime(2021, 01, 20), Return_date = new DateTime(2021, 01, 30), Flag_return = false };
        public Order Order11 = new Order { BookId = 4, UserId = 7, Date_of_issue = new DateTime(2021, 01, 22), Return_date = new DateTime(2021, 02, 01), Flag_return = true };
        public Order Order12 = new Order { BookId = 8, UserId = 8, Date_of_issue = new DateTime(2021, 01, 24), Return_date = new DateTime(2021, 02, 03), Flag_return = true };
        public Order Order13 = new Order { BookId = 15, UserId = 1, Date_of_issue = new DateTime(2021, 01, 28), Return_date = new DateTime(2021, 02, 07), Flag_return = true };
        public Order Order14 = new Order { BookId = 25, UserId = 2, Date_of_issue = new DateTime(2021, 01, 30), Return_date = new DateTime(2021, 02, 09), Flag_return = true };
        public Order Order15 = new Order { BookId = 1, UserId = 5, Date_of_issue = new DateTime(2021, 02, 05), Return_date = new DateTime(2021, 02, 15), Flag_return = true };
        public Order Order16 = new Order { BookId = 5, UserId = 3, Date_of_issue = new DateTime(2021, 02, 08), Return_date = new DateTime(2021, 02, 18), Flag_return = true };
        public Order Order17 = new Order { BookId = 10, UserId = 1, Date_of_issue = new DateTime(2021, 02, 15), Return_date = new DateTime(2021, 02, 25), Flag_return = true };
        public Order Order18 = new Order { BookId = 15, UserId = 6, Date_of_issue = new DateTime(2021, 02, 20), Return_date = new DateTime(2021, 03, 02), Flag_return = true };
        public Order Order19 = new Order { BookId = 20, UserId = 9, Date_of_issue = new DateTime(2021, 03, 05), Return_date = new DateTime(2021, 03, 15), Flag_return = true };
        public Order Order20 = new Order { BookId = 25, UserId = 1, Date_of_issue = new DateTime(2021, 03, 05), Return_date = new DateTime(2021, 03, 15), Flag_return = true };
        public Order Order21 = new Order { BookId = 2, UserId = 3, Date_of_issue = new DateTime(2021, 03, 12), Return_date = new DateTime(2021, 03, 22), Flag_return = true };
        public Order Order22 = new Order { BookId = 6, UserId = 2, Date_of_issue = new DateTime(2021, 03, 20), Return_date = new DateTime(2021, 03, 30), Flag_return = true };
        public Order Order23 = new Order { BookId = 11, UserId = 1, Date_of_issue = new DateTime(2021, 04, 03), Return_date = new DateTime(2021, 04, 13), Flag_return = true };
        public Order Order24 = new Order { BookId = 16, UserId = 10, Date_of_issue = new DateTime(2021, 04, 14), Return_date = new DateTime(2021, 04, 24), Flag_return = true };
        public Order Order25 = new Order { BookId = 21, UserId = 8, Date_of_issue = new DateTime(2021, 04, 22), Return_date = new DateTime(2021, 05, 02), Flag_return = true };
        public Order Order26 = new Order { BookId = 24, UserId = 1, Date_of_issue = new DateTime(2021, 04, 29), Return_date = new DateTime(2021, 05, 09), Flag_return = true };
        public Order Order27 = new Order { BookId = 23, UserId = 5, Date_of_issue = new DateTime(2021, 05, 08), Return_date = new DateTime(2021, 05, 18), Flag_return = true };
        public Order Order28 = new Order { BookId = 18, UserId = 7, Date_of_issue = new DateTime(2021, 05, 10), Return_date = new DateTime(2021, 05, 20), Flag_return = true };
        public Order Order29 = new Order { BookId = 13, UserId = 3, Date_of_issue = new DateTime(2021, 05, 24), Return_date = new DateTime(2021, 05, 04), Flag_return = true };
        public Order Order30 = new Order { BookId = 8, UserId = 2, Date_of_issue = new DateTime(2021, 06, 01), Return_date = new DateTime(2021, 06, 11), Flag_return = true };
        public Order Order31 = new Order { BookId = 14, UserId = 6, Date_of_issue = new DateTime(2021, 06, 07), Return_date = new DateTime(2021, 06, 07), Flag_return = true };
        public Order Order32 = new Order { BookId = 19, UserId = 4, Date_of_issue = new DateTime(2021, 06, 17), Return_date = new DateTime(2021, 06, 27), Flag_return = true };
        public Order Order33 = new Order { BookId = 4, UserId = 1, Date_of_issue = new DateTime(2021, 06, 20), Return_date = new DateTime(2021, 06, 30), Flag_return = true };
        public Order Order34 = new Order { BookId = 25, UserId = 2, Date_of_issue = new DateTime(2021, 07, 19), Return_date = new DateTime(2021, 07, 29), Flag_return = true };
        public Order Order35 = new Order { BookId = 3, UserId = 5, Date_of_issue = new DateTime(2021, 07, 28), Return_date = new DateTime(2021, 08, 09), Flag_return = true };
        public Order Order36 = new Order { BookId = 2, UserId = 10, Date_of_issue = new DateTime(2021, 08, 03), Return_date = new DateTime(2021, 08, 13), Flag_return = true };
        public Order Order37 = new Order { BookId = 12, UserId = 7, Date_of_issue = new DateTime(2021, 08, 10), Return_date = new DateTime(2021, 08, 20), Flag_return = true };
        public Order Order38 = new Order { BookId = 13, UserId = 4, Date_of_issue = new DateTime(2021, 08, 20), Return_date = new DateTime(2021, 08, 30), Flag_return = true };
        public Order Order39 = new Order { BookId = 3, UserId = 9, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = true };
        public Order Order40 = new Order { BookId = 17, UserId = 1, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public Order Order41 = new Order { BookId = 22, UserId = 2, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public Order Order42 = new Order { BookId = 23, UserId = 8, Date_of_issue = new DateTime(2021, 09, 05), Return_date = new DateTime(2021, 09, 15), Flag_return = false };
        public Order Order43 = new Order { BookId = 3, UserId = 3, Date_of_issue = new DateTime(2021, 09, 07), Return_date = new DateTime(2021, 09, 17), Flag_return = false };
        public Order Order44 = new Order { BookId = 24, UserId = 5, Date_of_issue = new DateTime(2021, 09, 10), Return_date = new DateTime(2021, 09, 20), Flag_return = false };
        public Order Order45 = new Order { BookId = 4, UserId = 2, Date_of_issue = new DateTime(2021, 09, 15), Return_date = new DateTime(2021, 09, 25), Flag_return = false };

        public void Record(AppContext db)
        {
            db.AddRange(Order1, Order2, Order3, Order4, Order5, Order6, Order7, Order8, Order9, Order10,
                        Order11, Order12, Order13, Order14, Order15, Order16, Order17, Order18, Order19, Order20,
                        Order21, Order22, Order23, Order24, Order25, Order26, Order27, Order28, Order29, Order30,
                        Order31, Order32, Order33, Order34, Order35, Order36, Order37, Order38, Order39, Order40,
                        Order41, Order42, Order43, Order44, Order45);
            db.SaveChanges();
        }
    }
}
