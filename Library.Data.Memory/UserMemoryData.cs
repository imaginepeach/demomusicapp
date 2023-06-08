using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Memory
{
    public class UserMemoryData : IDataUser<IUser>
    {
        private readonly List<IUser> _users;
        public UserMemoryData()
        {
            _users = new List<IUser>();
        }
        public bool Login(IUser item)
        {
            IUser? user = _users.FirstOrDefault(x => x.Email == item.Email && x.Password == item.Password);
            if (user != null) return true;
            else return false;
        }
        public IUser GetUser(IUser item)
        {
            IUser? user = _users.FirstOrDefault(x => x.Email == item.Email && x.Password == item.Password);
            return user;
        }

        public void Registration(IUser item)
        {
            IUser? user = _users.FirstOrDefault(x => x.Email == item.Email);

            if (user != null)
            {
                throw new Exception("Seems this email is taken by another pal!");
            }
            else _users.Add(item);
        }
/*        public void Take(ICheck check)
        {
            _users.First(x => x == check.User).Checks.Add(check);
        }
        public void Return(ICheck check)
        {
            _users.First(x => x == check.User).Checks.Remove(check);
        }*/
    }
}
