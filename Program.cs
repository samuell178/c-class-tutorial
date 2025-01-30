// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
namespace MyApplication
{
    class Program
    {
        static void Mhethod ()
        {
            Console.WriteLine("i just got richer");
            static void Main (string [] args)
            {
                MyMethod();
            }
        }
    }
}*/
/*class car 
{
    string color = "red";
    static void Main(string [] arg)
    {
        car myObj = new car ();
        Console.WriteLine(myObj.color );
    }
}
*/
/*using System.Drawing;

class car
{
    public string color = "red";
}


class Program
{
    static void Main(string [] arg)
    {
        car myobj = new car ();
        Console.WriteLine(myobj.color) ;
    }
}*/
/*using System.Security.Cryptography;
using oop;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("john ", 17, "medical");
        employee1.DisplayInfo();


    }
}*/
/*
using oop;

class Program
{
    static void Main(string[] args)
{
    student student = new student ();0
    student.Name = "samuel";
    student.Marks = new int[]  {10,20,30,40,550,60};
    double average = student.CalculateAverage();
    Console.WriteLine($"name: {student.Name}");
    Console.WriteLine($"average mark : {average}");
}
}.*/
/*class Program
{
    static void Main(string[] args)
    {
        ArrayProcessor processor = new ArrayProcessor();
        int [] numbers= {10, 20, 30, 40, 50, 60};
        int max = processor.FindMaximum(numbers);
        Console.WriteLine("maximum value : " + max);
    }

}
*/
using System.Diagnostics.Metrics;

class Program 
{
   static void Main(string[] args)
   {
    vowelCounter counter = new vowelCounter();
    string input = "programming is hard";
    int vowelCount = counter.countVowels(input);
    Console.WriteLine($"number of vowels : {vowelCount}");
   } 
}