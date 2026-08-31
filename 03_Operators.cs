using System;

public class _03_operators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        int sum = a + b; // Addition
        int sub = a - b;// Subtraction
        int multi = b * a;// Multiplication
        int mod = a % b;// Module
        a++;
        b--;

        Console.WriteLine($"Addition: {sum}");
        Console.WriteLine($"Subtraction: {sub}");
        Console.WriteLine($"Multiplication: {multi}");
        Console.WriteLine($"Modulus: {mod}");
        Console.WriteLine($"Increment: {a}");
        Console.WriteLine($"Decrement: {b}");
     }

 }