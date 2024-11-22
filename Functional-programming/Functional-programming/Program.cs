namespace Functional_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> results = Exercises001.Numbers.Select(Exercises001.AddTen).ToList();
            results.ForEach(x => Console.WriteLine(x));
            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            words.ForEach(x => Console.WriteLine(Exercises001.GrammarCheck(x)));
        }
    }
}
