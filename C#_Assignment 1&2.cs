// See https://aka.ms/new-console-template for more information

// 1. String
// int
// int
// string
// int
// String
// int
// int
// long
// long
// int
// 2. Variables of reference types store references to their data (objects), while variables of value types directly contain their data.
// boxing is a conversion from a value type to an object type, whereas the term unboxing refers to the conversion from an object type to a value type. 
// 3. Managed objects are created, managed by garbage collector
// Unmanaged objects are wrapped around operating system resources like file streams, database connections, network related instances, handles to different classes, registries, pointers, etc.
// 4. garbage collector manages the allocation and release of memory for your application.

using System;

/*class UnderstandingTypes
{
    public static void Main()
    {
        Console.WriteLine("SByte: " + "1 " + SByte.MinValue + " " + SByte.MaxValue);
        Console.WriteLine("Byte: " + "1 " + Byte.MinValue + " " + Byte.MaxValue);
        Console.WriteLine("Short: " + "16 " + Int16.MinValue + " " + Int16.MaxValue);
        Console.WriteLine("ushort: " + "16 " + UInt16.MinValue + " " + UInt16.MaxValue);
        Console.WriteLine("int: " + "32 " + Int32.MinValue + " " + Int32.MaxValue);
        Console.WriteLine("uint: " + "32 " + UInt32.MinValue + " " + UInt32.MaxValue);
        Console.WriteLine("long: " + "64 " + Int64.MinValue + " " + Int64.MaxValue);
        Console.WriteLine("ulong: " + "64 " + UInt64.MinValue + " " + UInt64.MaxValue);
        Console.WriteLine("float: " + "4 bytes " + float.MinValue + " " + float.MaxValue);
        Console.WriteLine("double: " + "8 bytes " + double.MinValue + " " + double.MaxValue);
        Console.WriteLine("decimal: " + "16 bytes " + decimal.MinValue + " " + decimal.MaxValue);

        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int) (years * 365.24);
        int hours = 24 * days;
        uint minutes = (uint) (60 * hours);
        ulong seconds = (ulong)60 * minutes;
        ulong milliseconds = 1000 * seconds;
        ulong microseconds = 1000 * milliseconds;
        ulong nanosecond = 1000 * microseconds;

        Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours + " hours = " + minutes + " minutes = " + seconds + " seconds = " + milliseconds + " milliseconds = " + microseconds + " microseconds = " +
            + nanosecond + " nanoseconds");
    }
}*/

// 1. it will throw a dividebyzeroexception exception
// throw a dividebyzeroexception exception
// the value will wrap and become nagative
// x = y++ : x = y, y = y+1; x = ++y: x = y+1; y = y+1
// The break statement, terminates the closest enclosing iteration statement or switch statement.
// The continue statement starts a new iteration of the closest enclosing iteration statement.
// The return statement: terminates execution of the function in which it appears and returns control to the caller.
// the keyword For that starts the loop, the condition being tested, and the EndFor keyword that terminates the loop
// the starts and the condition being tested
// = operator is used to assign value to a variable and == operator is used to compare two variable or constants.
// no
// the default keyword to signify that it should match anything if reached
// The IEnumerable interface

class Exercise
{
    public static void Main()
    {
        /*for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0) Console.WriteLine("fizz");
            else if (i % 5 == 0) Console.WriteLine("buzz");
            else Console.WriteLine(i);
        }*/
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine((i));
            // never stop because byte.Max = 255 is always smaller than max
        }
    }
}
