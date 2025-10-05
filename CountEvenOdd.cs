using System;

class CountEvenOdd
{
   static void Main()
   {
       Console.WriteLine("Enter 10 numbers separated by spaces:");
       string input = Console.ReadLine();           // Read the full line
       string[] parts = input.Split(' ');           // Split by spaces

       int evenCount = 0, oddCount = 0;

       for (int i = 0; i < parts.Length; i++)       // Loop through all numbers
       {
           int num = Convert.ToInt32(parts[i]);     // Convert each part to an integer

           if (num % 2 == 0)
               evenCount++;
           else
               oddCount++;
       }

       Console.WriteLine("\nTotal Even numbers: " + evenCount);
       Console.WriteLine("Total Odd numbers: " + oddCount);
   }
}

