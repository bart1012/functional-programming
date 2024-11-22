namespace Functional_programming
{
    public static class Exercises001
    {
        public static Func<int, int> SquareIt = x => x * x;
        public static Func<int, int> AddTen = x => x + 10;
        public static Predicate<string> GrammarCheck = s => s[0] == 'A' && s[s.Length - 1] == '!';
        public static Func<string, string, int> SumIndices = (s1, s2) => s1.IndexOf('a') + s2.IndexOf('e');
        public static List<int> Numbers = new List<int> { 4, 15, 55, 78, 12 };

        public static string CheckValidEmail(string input)
        {
            string[] splitInput = input.Split('@');

            Predicate<string> checkDomain = s => s == ("northcoders.co.uk");
            Predicate<string> checkLength = s => s.Length >= 5;

            if (checkDomain(splitInput[1]) && checkLength(splitInput[0]) && splitInput.Count() < 3)
                return "Email domain and user valid, please continue\r\n";
            else
                return "Email domain and user name invalid, please check your input\r\n";

        }
    }
}
