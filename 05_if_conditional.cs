using System;
public class _05_if_statement
{
    public static void Main(string[] args)
    {
        Console.Write("How Old You Are: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}