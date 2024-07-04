namespace linqHW
{
    public class PermutationsGivenString
    {
        public static void PermutationsGivenStringRun()
        {
            List<string> _expected = ["ABC", "ACB", "BAC", "BCA", "CBA", "CAB"];
            const string Given = "ABC";
            const string Given1 = "ABC";
            List<string> actual = new List<string>();

            /*Enumerable
            Foreach
            ElementAt
            Range*/

            var permutations = Given
                .SelectMany(num => Given1, (num, ch) => (num, ch));
                // .Select("{0}{1}", (num, ch) => $"{num}{ch}");
            
            
            //Enumerable
            //     .Range(0,Given.Length)
            //     .
            // Given.ElementAt(1);
            // Enumerable
            // .Range(0, Given.Length);
            // .SelectMany(i => Enumerable
            //     .Range(0, Given.Length - i)
            //     .Select(j => Given.Substring(i, j + 1)));


            // foreach (var permutation in permutations)
            // {
            //     actual.Add(permutation);
            // }

            actual.Sort();
            Console.WriteLine(actual.SequenceEqual(_expected));
        }
    }
}