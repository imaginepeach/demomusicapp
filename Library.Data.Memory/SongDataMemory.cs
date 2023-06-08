using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.IF;

namespace Library.Data.Memory
{
    public class BookMemoryData : IDataSong<ISong>
    {
        private readonly List<ISong> _books;

        public BookMemoryData()
        {
            _books = new List<ISong>();
        }

        public void Add(ISong item)
        {
            _books.Add(item);
        }

        public IEnumerable<ISong> ReadAll()
        {
            return _books;
        }
        public IEnumerable<ISong> FindGenre(Genre genre)
        {
            List<ISong> _booksOfGenre = new List<ISong>();
            foreach (ISong book in _books)
            {
                if (book.Genre == genre)
                {
                    _booksOfGenre.Add(book);
                }
            }
            return _booksOfGenre;
        }
        public IEnumerable<ISong> FindAuthor(string author)
        {
            List<ISong> _booksByAuthor = new List<ISong>();
            foreach (ISong book in _books)
            {
                if (book.Author == author)
                {
                    _booksByAuthor.Add(book);
                }
            }
            return _booksByAuthor;
        }
        public void Remove(ISong item)
        {
            _books.Remove(item);
        }
        public void Take(ISong item)
        {
            _books.First(x => x.Name == item.Name && x.Author == item.Author).isTaken = true;
        }
        public void Return(IFav item)
        {
            _books.First(x => x.Name == item.Book.Name && x.Author == item.Book.Author).isTaken = false;
        }
        public ISong FindBook(string name, string author)
        {
            return _books.FirstOrDefault(x => x.Name == name && x.Author == author);
        }
        public void AddReview((int, string, string) review, string name, string author)
        {
            _books.FirstOrDefault(x => x.Name == name && x.Author == author).Reviews.Add(review);
        }
    }
}
