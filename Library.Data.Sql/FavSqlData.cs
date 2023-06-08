using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data.Sql
{
    public class FavSqlData : IDataFav<IFav>
    {
        public void Add(IFav item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                var check = new FavEntity(item);
                db.Checks.Add(check);
                db.SaveChanges();
            }
        }

        public IEnumerable<IFav> ReadAll(IUser user)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                List<FavEntity> _checks = new List<FavEntity>();
                foreach (FavEntity check in db.Checks.ToList())
                {
                    if (check.IdUser == user.Email)
                    {
                        _checks.Add(check);
                    }
                }
                return _checks;
            }
        }

        public void Remove(IFav item)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                var check = db.Checks.SingleOrDefault(
                    x => x.BookName.Equals(item.BookName) &&
                    x.IdUser.Equals(item.IdUser));
                db.Checks.Remove(check);
                db.SaveChanges();
            }
        }
        public IFav Find(ISong book)
        {
            using (MusicAppContext db = new MusicAppContext())
            {
                return db.Checks.SingleOrDefault(x => x.Book == book);
            }
        }
    }
}
