public class VowelCounter
{
    public int countVowels (string input)
    {
        int VowelCount = 0;
        string Vowels = "aeiouAEIOU";
        foreach (char c in input)
        {
            if (Vowels.IndexOf(c) !=-1)
            {
                VowelCount++;
            }
        }
        return VowelCount;
    }
}