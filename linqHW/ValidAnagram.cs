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
            var sum = anagram.Select(c => (int)c)
                .Sum();
            var secondSum = nagaram.Select(c => (int)c)
                .Sum();
            return sum == secondSum;
        }
    }
}