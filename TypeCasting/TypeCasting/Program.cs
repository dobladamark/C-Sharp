using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(String[] args)
        {
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool2));   // convert bool to string
        }
    }
}