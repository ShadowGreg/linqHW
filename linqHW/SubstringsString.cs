using ConsoleTableExt;

namespace linqHW
{
    public class SubstringsString
    {
        private const string Text = "abcd";

        public static void DoSubstring()
        {
            List<string> endSubstrings = new List<string>();
            // List<string> endSubstrings = Text.Select(c => c.ToString()).ToList();

            for (int i = 0; i < Text.Length; i++)
            {
                for (int j = 1; j <= Text.Length - i; j++)
                {
                    var substring = Text.Substring(i, j);
                    endSubstrings.Add(substring);
                }
            }

            Console.WriteLine("Equals returns: " + Equals(endSubstrings,
                new List<string> { "a", "b", "c", "d", "ab", "bc", "cd", "abc", "bcd", "abcd" }));
            ConsoleTableBuilder
                .From(endSubstrings)
                .WithTitle("Words")
                .ExportAndWriteLine();
        }
    }
}