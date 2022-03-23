using SF_25.Entities;

namespace SF_25.DataForDB_
{
    public class Publishing_housesData
    {
        public Publishing_house Publishing_house1 = new Publishing_house { Name = "Эксмо" };
        public Publishing_house Publishing_house2 = new Publishing_house { Name = "Просвещение" };
        public Publishing_house Publishing_house3 = new Publishing_house { Name = "Азбука" };
        public Publishing_house Publishing_house4 = new Publishing_house { Name = "Дрофа" };
        public Publishing_house Publishing_house5 = new Publishing_house { Name = "Алтапресс" };
        public Publishing_house Publishing_house6 = new Publishing_house { Name = "Самокат" };

        public void Record(AppContext db)
        {            
            db.Publishing_houses.AddRange(Publishing_house1, Publishing_house2, Publishing_house3, Publishing_house4,
                                          Publishing_house5, Publishing_house6);
            db.SaveChanges();
        }
    }
}
