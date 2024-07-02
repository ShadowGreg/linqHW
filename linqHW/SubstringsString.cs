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

            // for (int i = 0; i < Text.Length; i++)
            // {
            //     for (int j = 1; j <= Text.Length - i; j++)
            //     {
            //         string substring = Text.Substring(i, j);
            //         endSubstrings.Add(substring);
            //     }
            // }

            List<int> countCollection = GetCountCollection(Text);


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

        private static List<int> GetCountCollection(string text)
        {
            int i = 0;
            return text.Select(ch => i++).ToList();
        }
    }
}