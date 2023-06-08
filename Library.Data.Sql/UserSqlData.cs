using Library.IF;
using Music.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data.Sql
{
    public class UserSqlData : IDataUser<IUser>
    {
        public bool Login(IUser item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                IUser? user = db.Users.SingleOrDefault(x => x.Email == item.Email && x.Password == item.Password);
                if (user != null) return true;
                else return false;
            }
        }
        public IUser GetUser(IUser item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                IUser? user = db.Users.SingleOrDefault(x => x.Email == item.Email && x.Password == item.Password);
                return user;
            }
        }

        public void Registration(IUser item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                IUser? user = db.Users.SingleOrDefault(x => x.Email == item.Email);

                //item.Checks = new CheckSqlData();

                if (user != null)
                {
                    throw new Exception("This email is taken by another user lol");
                }
                else
                {
                    var newUser = new UserEntity(item);
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
            }
        }
        /*public void Take(ICheck item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var check = new CheckEntity(item);
                db.Users.First(x => x == check.User).Checks.Add(check);
                db.SaveChanges();
            }
        }
        public void Return(ICheck item)
        {
            using (LibraryContext db = new LibraryContext())
            {
                var check = db.Checks.SingleOrDefault(
                    x => x.Book.Equals(item.Book) &&
                    x.User.Equals(item.User));
                db.Users.First(x => x == check.User).Checks.Add(check);
                db.SaveChanges();
            }
        }*/
    }
}
