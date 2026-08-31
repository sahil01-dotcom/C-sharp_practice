using System;
public class _06_else_if_statement
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Any Number: ");
        int num = int.Parse(Console.ReadLine());

        if (num %2 == 0)
         {
            Console.WriteLine("Even number");
         }
        else
        {
            Console.WriteLine("Odd number");
        }
    }

}
