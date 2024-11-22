namespace Functional_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> results = Exercises001.Numbers.Select(Exercises001.AddTen).ToList();
            //results.ForEach(x => Console.WriteLine(x));
            //List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            //words.ForEach(x => Console.WriteLine(Exercises001.GrammarCheck(x)));
            //Console.WriteLine(Exercises001.SumIndices("start", "pale"));
            //Console.WriteLine(Exercises001.CheckValidEmail("rich1222@northcoders.co.uk"));
            //Console.WriteLine(String.Join(", \n", Exercises002.GetCoolPeople()));
            //List<string> list = Exercises002.GetCoolPeople();
            //Exercises002.PrintCoolPeople(list);
            //list.ForEach(x => Exercises002.GetUserNames(x));
            //List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
            //Exercises002.PrintSquaredNums(numList);
            List<string> emailList = new List<string>
                {
                    "alice.yang@northcoders.com",
                    "richard.neat@northcoders.com",
                    "mario@plumbing.it",
                    "link@hyrule.co.uk",
                    "shrek@duloc.com",
                    "neil.hughes@walkingoncustard.com",
                    "csharp@microsoft.cs",
                    "ziggy@spidersfrommars.co.uk",
                    "lemmy@motorhead.co,uk",
                    "me@myhouse.sleep"
                };

            var filteredEmails = Exercises002.FilterEmails(emailList);

            foreach (var item in filteredEmails)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(Console.WriteLine);
            }

        }
    }
}
