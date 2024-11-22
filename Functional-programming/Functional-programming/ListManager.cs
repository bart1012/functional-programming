using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
    public class ListManager
    {
        private List<string> _list;
        public ListManager(List<string> list)
        {
            _list = list;
        }

        public List<string> Filter(Predicate<string> predicate)
        {
            return _list.Where(x => predicate(x)).ToList();
        }
    }
}
