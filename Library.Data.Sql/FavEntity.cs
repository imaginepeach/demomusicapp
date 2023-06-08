using Library.IF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data.Sql
{
    public class FavEntity : IFav
    {
        public int Id { get; set; }
        public string LibraryAddress { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string IdUser { get; set; }
        [NotMapped]
        public ISong Book { get; set; }
        [NotMapped]
        public IMusicApp Library { get; set; }
        public int Time { get; set; }
        [NotMapped]
        public IUser User { get; set; }
        public DateTime DateTime { get; set; }

        public FavEntity() { }

        public FavEntity(IFav item)
        {
            Id = 0;
            Library = item.Library;
            LibraryAddress = item.Library.Address;
            Book = item.Book;
            BookName = item.Book.Name;
            BookAuthor = item.Book.Author;
            IdUser = item.User.Email;
            Time = item.Time;
            DateTime = item.DateTime;
            User = item.User;
        }
        public override string ToString()
        {
            return $"{BookName} - {BookAuthor}";
        }
    }
}
