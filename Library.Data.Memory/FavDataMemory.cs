using Library.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Memory
{
    public class CheckMemoryData : IDataFav<IFav>
    {
        private readonly List<IFav> _checks;

        public CheckMemoryData()
        {
            _checks = new List<IFav>();
        }

        public void Add(IFav item)
        {
            _checks.Add(item);
        }

        public IEnumerable<IFav> ReadAll(IUser user)
        {
            List<IFav> checks = new List<IFav>();
            foreach (IFav check in _checks)
            {
                if (check.User == user)
                {
                    checks.Add(check);
                }
            }
            return checks;
        }

        public void Remove(IFav item)
        {
            _checks.Remove(item);
        }
        public IFav Find(ISong book) 
        {
            return _checks.FirstOrDefault(x => x.Book == book);
        }
    }
}
