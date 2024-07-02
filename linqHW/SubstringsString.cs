using ConsoleTableExt;

namespace linqHW
{
    public class SubstringsString
    {
        private const string Text = "abcd";

        public static void DoSubstring()
        {
            var expected = new List<string> { "a", "b", "c", "d", "ab", "bc", "cd", "abc", "bcd", "abcd" };
            expected.Sort();

            List<string> endSubstrings = new List<string>();

            endSubstrings = Enumerable.Range(0, Text.Length)
                .SelectMany(i => Enumerable.Range(1, Text.Length - i)
                    .Select(j => Text.Substring(i, j))).ToList();

            Console.Clear();
            Console.WriteLine();
            var sorted = endSubstrings.OrderBy(word => word).ToList();

            Console.WriteLine("Equals returns: " + sorted.SequenceEqual(expected));
            ConsoleTableBuilder
                .From(endSubstrings)
                .WithTitle("Words")
                .ExportAndWriteLine();
        }
    }
}