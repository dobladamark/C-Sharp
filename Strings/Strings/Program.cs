using System;

namespace Variable
{
    class Program
    {
        static void Main(String[] args)
        {

            string gretting = "Hello";
            string greeting2 = "World";
            string greeting3 = gretting + " " + greeting2;


            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);


            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());


            //string firstName = "John";
            //string lastName = "Doe";
            //string name = firstName + " " + lastName;
            //Console.WriteLine("My name is: " + name);

            //string firstName = "John";
            //string lastName = "Doe";
            //string name = string.Concat(firstName, " ", lastName);
            //Console.WriteLine(name);

            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine("The sum of x and y is: " + z);

            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2;
            Console.WriteLine("The concatenation of x2 and y2 is: " + z2);

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is :  + {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "Hello, World!";
            Console.WriteLine(myString[0]); // Outputs 'H'
            Console.WriteLine(myString[7]); // Outputs 'W'
            Console.WriteLine(myString.IndexOf("e")); // Outputs 1
            Console.WriteLine(myString.IndexOf("World")); // Outputs 7

            string name2 = "John Doe";

            int charPos = name2.IndexOf("D");

            string lastName2 = name2.Substring(charPos);
            Console.WriteLine("Last name is: " + lastName2);

            string txt3 = "Hello\"Universe\" World";
            Console.WriteLine(txt3);

            string txt4 = "It\'s a beautiful day!";
            Console.WriteLine(txt4);
        } 
    }
}