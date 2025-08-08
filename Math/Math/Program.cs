using System;

namespace MyMathExample 

{
    class Program
    {
        static void Main(String[] args)
        {
            //The C# Math class has many methods that allows you to perform mathematical tasks on numbers.

            //The Math.Max(x,y) method can be used to find the highest value of x and y:

            int x = 5;
            int y = 10;
            int max = Math.Max(x, y);
            Console.WriteLine("The maximum value is: " + max);

            //The Math.Abs(x) method returns the absolute (positive) value of x:
            int negativeValue = -20;
            int absoluteValue = Math.Abs(negativeValue);
            Console.WriteLine("The absolute value is: " + absoluteValue);

            //Math.Round() rounds a number to the nearest whole number:
            double numberToRound = 7.5;
            double roundedNumber = Math.Round(numberToRound);
            Console.WriteLine("The rounded number is: " + roundedNumber);
            //Math.Sqrt() returns the square root of a number:
            double numberToSqrt = 16.0;
            double squareRoot = Math.Sqrt(numberToSqrt);
            Console.WriteLine("The square root is: " + squareRoot);
 
            
        }
    }
}