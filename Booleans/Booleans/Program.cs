using System;

namespace Booleans;

class Program
{
    static void Main(string[] args)
    {
        bool isCSharpFun = true;
        bool isFishTasty = false;
        Console.WriteLine(isCSharpFun);   // Outputs True
        Console.WriteLine(isFishTasty);   // Outputs False
        int x = 10;
        int y = 9;
        Console.WriteLine(x > y); // returns True, because 10 is higher than 9
        Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
        int x1 = 10;
        Console.WriteLine(x1 == 10); // returns True, because the value of x is equal to 10
        Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15
        int myAge = 25;
        int votingAge = 18;
        Console.WriteLine(myAge >= votingAge);

        if (myAge >= votingAge)
        {
            Console.WriteLine("Old enough to vote!");
        }
        else
        {
            Console.WriteLine("Not old enough to vote.");
        }

        bool isRaining = false;
        if (isRaining)
        {
            Console.WriteLine("Take an umbrella.");
        }
        else
        {
            Console.WriteLine("No need for an umbrella.");
        }
        bool isWeekend = true;
        if (isWeekend)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }
    }
}