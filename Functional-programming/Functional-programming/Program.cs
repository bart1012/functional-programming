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
            Console.WriteLine(String.Join(", \n", Exercises002.GetCoolPeople()));
            List<string> list = Exercises002.GetCoolPeople();
            Exercises002.PrintCoolPeople(list);
            //list.ForEach(x => Exercises002.GetUserNames(x));
        }
    }
}
