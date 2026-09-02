using System;
 public class _10_while_loop
    {
    public static void Main(string[] args)
    {
        int i = 1;
        
        while (i <= 10)
        {
            Console.WriteLine(i);

            // Check if the number is even or odd
            if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            i++;
        }
    }
  
}
