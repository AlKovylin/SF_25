using SF_25.Entities;

namespace SF_25.DataForDB_
{
    public class GenresData
    {
        public Genre Genre1 = new Genre { Name = "Фантастика" };
        public Genre Genre2 = new Genre { Name = "Приключения" };
        public Genre Genre3 = new Genre { Name = "Детектив" };
        public Genre Genre4 = new Genre { Name = "Исторический роман" };

        public void Record(AppContext db)
        {
            //db.Genres.AddRange(Genre1, Genre2, Genre3, Genre4);
            //db.SaveChanges();
            db.Genres.Add(Genre1);
            db.SaveChanges();

            db.Genres.Add(Genre2);
            db.SaveChanges();

            db.Genres.Add(Genre3);
            db.SaveChanges();

            db.Genres.Add(Genre4);
            db.SaveChanges();
        }
    }
}
