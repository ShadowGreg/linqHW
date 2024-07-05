namespace linqHW
{
    public class PermutationsGivenString
    {
        public static void PermutationsGivenStringRun()
        {
            List<string> expected = ["ABC", "ACB", "BAC", "BCA", "CBA", "CAB"];
            const string given = "ABC";
           

            var actual = given
                .SelectMany(num => given, (num, ch) => (num, ch))
                .Select(tuple => $"{tuple.num}{tuple.ch}")
                .SelectMany(num => given, (num, ch) => (num, ch))
                .Select(tuple => $"{tuple.num}{tuple.ch}")
                .Where(str => str.GroupBy(c => c).All(g => g.Count() == 1)) 
                .ToHashSet().ToList();
              
            actual.Sort();
            expected.Sort();
            Console.WriteLine(actual.SequenceEqual(expected));
        }
    }
}