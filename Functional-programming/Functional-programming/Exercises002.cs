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
    }
}
