using Library.IF;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Music.Data.Sql
{
    public class SongSqlData : IDataSong<ISong>
    {
        public void Add(ISong item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                var book = new SongEntity(item);
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public IEnumerable<ISong> ReadAll()
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                return db.Books.ToList();
            }
        }
        public IEnumerable<ISong> FindGenre(Genre genre)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                List<SongEntity> _booksOfGenre = new List<SongEntity>();
                foreach (SongEntity book in db.Books.ToList())
                {
                    if (book.Genre == genre)
                    {
                        _booksOfGenre.Add(book);
                    }
                }
                return _booksOfGenre;
            }
        }
        public IEnumerable<ISong> FindAuthor(string author)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                List<SongEntity> _booksByAuthor = new List<SongEntity>();
                foreach (SongEntity book in db.Books.ToList())
                {
                    if (book.Author.ToLower().IndexOf(author.ToLower()) > -1)
                    {
                        _booksByAuthor.Add(book);
                    }
                }
                return _booksByAuthor;
            }
        }
        public void Remove(ISong item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                var book = db.Books.SingleOrDefault(
                    x => x.Author.Equals(item.Author) &&
                    x.Name.Equals(item.Name));
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        public void Take(ISong item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                db.Books.First(x => x.Name == item.Name && x.Author == item.Author).isTaken = true;
                db.SaveChanges();
            }
        }
        public void Return(IFav item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {

                db.Books.First(x => x.Name == item.BookName && x.Author == item.BookAuthor).isTaken = false;
                db.SaveChanges();
            }
        }
        public ISong FindBook(string name, string author)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                ISong book = db.Books.FirstOrDefault(x => x.Name == name && x.Author == author);
                return book;
            }
        }
        public void AddReview((int, string, string) review, string name, string author)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                List<(int, string, string)> list = JsonConvert.DeserializeObject<List<(int, string, string)>>(db.Books.First(x => x.Name == name && x.Author == author).ReviewsJson);
                if (list == null)
                {
                    list = new List<(int, string, string)>();
                }
                list.Add(review);
                db.Books.First(x => x.Name == name && x.Author == author).ReviewsJson = JsonConvert.SerializeObject(list);
                db.SaveChanges();
            }
        }
    }
}
