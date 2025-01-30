/*namespace oop
{
    public class Employee
{
    public string Name {get; set;}
    public int Age  {get ; set; }
    public string Department {get ; set;}




    public Employee(string Name, int Age, string Department)
    {
        this.Name = Name;

        this.Age = Age;
        this.Department = Department;
    }



    public void DisplayInfo ()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"age:{Age}");
        Console.WriteLine($"department:{Department}");

    }    
}
}/*
{
    public class student
    {
        public string Name {get; set;}
        public int[] Marks  {get; set;}
                        

        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
            }
            return (double)sum / Marks.Length;
        }
        
            
        
    }
}
*/
/*public class ArrayProcessor 
{
    public int FindMaximum (int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}*/
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