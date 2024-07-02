using ConsoleTableExt;

namespace linqHW
{
    public class SubstringsString
    {
        private const string Text = "abcd";

        public static void DoSubstring()
        {
            List<string> substrings = Text
                .Select(c => c.ToString())
                .ToList();
            List<string> newSubstring = Text
                .Take(Text.Length - 1)
                .Select(c=>c.ToString())
                .ToList();
            
            
            
            
            
            
            ConsoleTableBuilder
                .From(substrings)
                .WithTitle("Words")
                .ExportAndWriteLine();

        }
    }
}