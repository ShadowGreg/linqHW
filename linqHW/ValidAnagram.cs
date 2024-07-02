namespace linqHW
{
    public class ValidAnagram
    {
        public static void DoAnagram()
        {
            string anagram = "anagram", nagaram = "nagaram";
            bool isAnagram = true;


            bool isAnagramTo = GetAnswer(anagram, nagaram);

            Console.WriteLine(Equals(isAnagram, isAnagramTo));

        }

        private static bool GetAnswer(string anagram, string nagaram)
        {
            return anagram.Length == nagaram.Length && anagram.OrderBy(x => x).SequenceEqual(nagaram.OrderBy(x => x));
        }
    }
}