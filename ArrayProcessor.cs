public class ArrayProcessor 
{
    public int FindMaximum (int[] Numbers)
    {
        int Max = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] > Max)
            {
                Max = Numbers[i];
            }
        }
        return Max;
    }
}