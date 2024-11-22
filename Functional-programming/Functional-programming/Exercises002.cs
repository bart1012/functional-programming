using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Functional_programming
{
    internal static class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => [
            "rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com", 
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"
            ];
        public static Action<string> GetUserNames = (s) =>
        {
            string[] parts = s.Split('@');
            Console.WriteLine(parts[0]);
        };
        public static Action<List<string>> PrintCoolPeople = (l) =>
        {
            foreach (string s in l) Console.WriteLine(s);
        };
        public static Action<List<int>> SquaredNums = (l) =>
        {
            for (int i = 0; i < l.Count; i++) l[i] = l[i] * l[i];
        };
        public static Action<List<int>> PrintNums = (l) =>
        {
            l.ForEach(Console.WriteLine);
        };
        public static Action<List<int>> PrintSquaredNums = (l) =>
        {
            SquaredNums(l);
            PrintNums(l);
        };
    }
}
