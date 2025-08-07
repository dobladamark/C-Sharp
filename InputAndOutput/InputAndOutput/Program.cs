using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age : ");
        string input = Console.ReadLine();

        int age = int.Parse(input);

        Console.WriteLine("Your age is: " + age + " years old.");
        
    }
}