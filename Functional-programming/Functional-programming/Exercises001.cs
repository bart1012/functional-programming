using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
    public static class Exercises001
    {
        public static Func<int, int> SquareIt = x => x * x;
        public static Func<int, int> AddTen = x => x + 10;
        public static Predicate<string> GrammarCheck = s => s[0] == 'A' && s[s.Length - 1] == '!';
        public static List<int> Numbers = new List<int> { 4, 15, 55, 78, 12 };
    }
}
