using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface IMusicApp
    {
        string Address { get; set; }
        IEnumerable<ISong> GetAllBooks();

        IEnumerable<IFav> GetChecks(IUser user);
        void TakeBook(IFav check);
        ISong GetBook(string name, string author);
        IEnumerable<ISong> FindBooksAuthor(string author);
        IEnumerable<ISong> FindBooksGenre(Genre genre);
        void ReturnBook(IFav check);
        void AddBook(ISong book);
        bool Login(IUser user);
        void Registration(IUser user);
        void AddReview((int, string, string) review, string name, string author);
        IUser GetUser(IUser user);
    }
}
