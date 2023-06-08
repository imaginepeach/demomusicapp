using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface IDataSong<T>
    {
        IEnumerable<T> ReadAll();
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> FindGenre(Genre genre);
        IEnumerable<T> FindAuthor(string author);
        void Take(T item);
        void Return(IFav item);
        T FindBook(string name, string author);
        void AddReview((int, string, string) review, string name, string author);
    }
}
