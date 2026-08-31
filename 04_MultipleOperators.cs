using System;
public class _04_MultipleOperators
 {
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        Console.WriteLine("num_1 = 10");
        Console.WriteLine("num_2 = 5");

        //Arithmetic operators:
        Console.WriteLine($"\n Arithmetic Operators");
        Console.WriteLine($"Addition: " + (a + b));
        Console.WriteLine($"Subtraction: "  + (a - b));
        Console.WriteLine($"Multiplication: " + (a * b));
        Console.WriteLine($"Division: " + (a / b));

        //Comparison operators : 
        Console.WriteLine("\n Comparison Operators");
        Console.WriteLine($"a==b: " + (a == b));
        Console.WriteLine($"a!=b: "   + (a != b));
        Console.WriteLine($"a>b: " + (a > b));
        Console.WriteLine($"a<b: " + (a < b));
    }
}
