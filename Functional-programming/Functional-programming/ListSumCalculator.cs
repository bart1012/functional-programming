using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
    public class ListSumCalculator<T>
    {
        public List<T> List { get; set; }
        public ListSumCalculator(List<T> list)
        {
            List = list;
        }
        public int SumBy(Func<T, int> lambda) // SumBy(p => p.Age)
        {
            return List.Sum(lambda);
        }

        //public void test()
        //{
        //    Person p = new("8923749", 20);
        //    SumBy(p => p.Age);
        //}
    }
}
