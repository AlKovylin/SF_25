using SF_25.DataForDB_;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25
{
    public class AddDataInDB
    {
        AuthorsData AD = new AuthorsData();
        GenresData GD = new GenresData();
        Publishing_housesData PD = new Publishing_housesData();
        BooksData BD = new BooksData();
        UsresData UD = new UsresData();
        OrderData OD = new OrderData();

        public void AddData(AppContext db)
        {        
            AD.Record(db);
            GD.Record(db);
            PD.Record(db);
            BD.Record(db);
            UD.Record(db);
            OD.Record(db);
        }
    }
}
