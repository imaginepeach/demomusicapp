using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IF
{
    public interface IFav
    {
        ISong Book { get; set; }
        IMusicApp Library { get; set; }
        int Time { get; set; }
        IUser User { get; set; }
        DateTime DateTime { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string IdUser { get; set; }
    }
}
