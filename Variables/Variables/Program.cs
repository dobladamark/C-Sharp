using System;

namespace Variable
{
    class Program
    {
        static void Main(String[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine("My num is " + myNum);
            Console.WriteLine("My DoubleNum is " + myDoubleNum);
            Console.WriteLine("My Char is " + myLetter);
            Console.WriteLine("My Bool is " + myBool);
            Console.WriteLine("My String is " + myText);

            //Constants
            const int myNum1 = 15;
            //myNum1 = 20; // error
            //cannot be change 

            string firstName = "Mark";
            string lastName = "Doblada";
            string fullname = firstName + " " + lastName;
            Console.WriteLine("My Fullname is " + fullname);

            int x = 5;
            int y = 10;
            Console.WriteLine("The sum of x and y is " + (x + y));


            int a = 5, b = 7, c = 9;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }
}

