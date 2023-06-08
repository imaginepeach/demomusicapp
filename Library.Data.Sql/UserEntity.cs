using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data.Sql
{
    public class UserEntity : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserEntity() { }

        public UserEntity(IUser item)
        {
            Id = 0;
            Name = item.Name;
            Email = item.Email;
            Password = item.Password;
        }
        //public IDataCheck<ICheck> Checks { get; set; }
    }
}
