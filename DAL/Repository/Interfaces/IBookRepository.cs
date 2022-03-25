﻿using SF_25.DAL.Entitys;
using SF_25.DAL.QueryEntitys;
using System.Collections.Generic;

namespace SF_25.DAL.Interfaces.Repository
{
    public interface IBookRepository
    {
        void AddNewAuthor(AuthorEntity author);
        void AddNewBook(BookEntity book);
        void AddNewGenre(GenreEntity genre);
        void AddNewPublishing_house(Publishing_houseEntity publishing_house);
        void DeleteBook(BookEntity book);
        List<AuthorEntity> GetAllAuthors();
        List<BookQueryEntity> GetAllBooks();
        List<GenreEntity> GetAllGenres();
        List<Publishing_houseEntity> GetAllPublishing_houses();
    }
}