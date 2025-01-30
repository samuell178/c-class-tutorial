public class vowelCounter
{
    public int countVowels (string input)
    {
        int vowelCount = 0;
        string Vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (Vowels.IndexOf(c) !=-1)
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}