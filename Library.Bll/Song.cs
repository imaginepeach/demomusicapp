using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.IF;

namespace Library.Bll
{
    public class Song : ISong
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public bool isTaken { get; set; }
        public List<(int, string, string)> Reviews { get; set; }
        public string ReviewsJson { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Author}, {Genre}";
        }
    }
}
