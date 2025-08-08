using System;

namespace DataTypes
{
    class Program
    {
        static void Main(String[] args)
        {
            //The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.
            int myNum = 100000;
            Console.WriteLine(myNum);
            // The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807. The long data type is used when you need a larger range than the int data type.
            long myLongNum = 15000000000L;
            Console.WriteLine(myLongNum);
            // The float data type can store fractional numbers. It is used when you need a number with a decimal point, but you do not need the precision of a double.
            float myFloatNum = 5.75f;
            Console.WriteLine(myFloatNum);
            // The double data type can store fractional numbers with double precision. It is used when you need a number with a decimal point and require more precision than a float.
            double myDoubleNum = 19.99;
            Console.WriteLine(myDoubleNum);
            // The decimal data type is used for financial and monetary calculations. It has a higher precision than float and double, making it suitable for calculations that require exact decimal representation.
            decimal myDecimalNum = 19.99m;
            Console.WriteLine(myDecimalNum);
            // The char data type can store a single character. It is used when you need to store a single letter, digit, or symbol.
            char myChar = 'A';
            Console.WriteLine(myChar);
            // The string data type can store a sequence of characters. It is used when you need to store text.
            string myString = "Hello, World!";
            Console.WriteLine(myString);
            // The bool data type can store a value of either true or false. It is used for logical operations and conditions.
            bool myBool = true;
            Console.WriteLine(myBool);
            // The object data type can store any data type. It is the base type for all data types in C#. It is used when you need to store a value of any type, but you lose type safety.
            object myObject = "This is an object";
            Console.WriteLine(myObject);
            // The dynamic data type can store any data type and allows for late binding. It is used when you need to work with types that are not known at compile time.
            dynamic myDynamic = "This is dynamic";
            Console.WriteLine(myDynamic);
            // The var keyword allows you to declare a variable without specifying its type. The type is inferred at compile time based on the assigned value.
            var myVar = 42;
            Console.WriteLine(myVar);

            // The nullable data type allows you to assign null to value types. It is used when you need to represent a value that can be absent.
            int? myNullableInt = null;
            Console.WriteLine(myNullableInt.HasValue ? myNullableInt.Value.ToString() : "null");
            // The enum data type allows you to define a set of named constants. It is used when you need to represent a fixed set of related values.
            DayOfWeek myDay = DayOfWeek.Monday;
            Console.WriteLine(myDay);

            // The DateTime data type represents a specific point in time. It is used when you need to work with dates and times.
            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);
            // The TimeSpan data type represents a time interval. It is used when you need to work with durations or differences between two points in time.
            TimeSpan myTimeSpan = new TimeSpan(1, 2, 3); // 1 hour, 2 minutes, and 3 seconds
            Console.WriteLine(myTimeSpan);

            // The Guid data type represents a globally unique identifier. It is used when you need to generate unique identifiers for objects.
            Guid myGuid = Guid.NewGuid();
            Console.WriteLine(myGuid);
            // The Tuple data type allows you to store a fixed-size collection of items of different types. It is used when you need to group related values together without creating a custom class.
            var myTuple = Tuple.Create(1, "Hello", 3.14);
            Console.WriteLine($"Tuple: Item1 = {myTuple.Item1}, Item2 = {myTuple.Item2}, Item3 = {myTuple.Item3}");
        }   

    }
}