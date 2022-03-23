using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using SF_25.Entities;

namespace SF_25
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        // Объекты таблицы Books
        public DbSet<Book> Books { get; set; }

        // Объекты таблицы Authors
        public DbSet<Author> Authors { get; set; }

        // Объекты таблицы Genres
        public DbSet<Genre> Genres { get; set; }

        // Объекты таблицы Orders
        public DbSet<Order> Orders { get; set; }

        // Объекты таблицы Publishing_houses
        public DbSet<Publishing_house> Publishing_houses { get; set; }

        public bool Exists()
        {
            return (this.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists();
        }

        public bool CreatedDB()
        {
            return Database.EnsureCreated();
        }

        public bool DeletedDB()
        {
            return Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.MsSqlConnection);
        }
    }
}
