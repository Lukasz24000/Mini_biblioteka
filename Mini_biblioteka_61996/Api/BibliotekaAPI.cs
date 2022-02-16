using Mini_biblioteka_61996.mapping;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_biblioteka_61996.Api
{
    public class BibliotekaAPI
    {
        public BibliotekaAPI()
        {
            NHibernateBase nHibernate = new NHibernateBase();
            nHibernate.Initialize();
        }

        public void AddBook(Book book)
        {
            using (var session = NHibernateBase.Session)
            {
                session.Save(book);
            }
        }

        public List<IdBook> GetBooks()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<Book>().Select(
                    x => new IdBook
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Author = x.Author,
                        Year= x.Year,
                        All = x.Title + " " + x.Author + " | " + x.Year.ToString(),
                    }).ToList();
            }
        }

        public void AddReader(Reader reader)
        {
            using (var session = NHibernateBase.Session)
            {
                session.Save(reader);
            }
        }

        public List<IdReader> GetReaders()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<Reader>().Select(
                    x => new IdReader
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Surname = x.Surname,
                        Street = x.Street,
                        StreetNumber = x.StreetNumber,
                        PostCode = x.PostCode,
                        All = x.Name +" "+ x.Surname + " | " + x.Street + " | " + x.StreetNumber.ToString() + " | " + x.PostCode.ToString(),
                    }).ToList();
            }
        }



        public void AddBorrowing(Borrowing borrowing)
        {
            using (var session = NHibernateBase.Session)
            {
                session.Save(borrowing);
            }
        }

        public List<IdBorrows> GetBorrows()
        {
            using (var session = NHibernateBase.Session)
            {
                return session.Query<Borrowing>().Select(
                    y => new IdBorrows
                    {
                        Id = y.Id,
                        Reader = y.Reader.Name + " " + y.Reader.Surname,
                        Book = y.Book.Title + " " + y.Book.Year,
                        BorrowDate = y.BorrowDate.ToString("yyyy'-'MM'-'dd"),
                        ReturnDate = y.ReturnDate.ToString("yyyy'-'MM'-'dd"),
                    }).ToList();
            }
        }

    }
}