//Check whether the student is pass or fail
using System;
public class pass_fail_Grade
{
    public static void Main(string[] args)
     {
        int marks;

        Console.Write("Enter Student's Marks: ");
        marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90)
        {
            Console.WriteLine("Result: Pass");
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 40) 
        {
            Console.WriteLine("Result: Pass");
            Console.WriteLine("Grade: D");
        }
        else if(marks>=35)
        {
            Console.WriteLine("Result: Pass");
            Console.WriteLine("Grade: E");
        }


        else
        {
            Console.WriteLine("Result: Fail");
            Console.WriteLine("Grade: F");
            Console.WriteLine("Better Luck Next Time!");
            
        }
    }
}