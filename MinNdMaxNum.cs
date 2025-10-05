using System;

class ArrayMaxMin
{
    static void Main()
    {
        Console.WriteLine("Enter 10 numbers separated by spaces:");
        string input = Console.ReadLine();               // Read the full line as a string
        string[] parts = input.Split(' ');               // Split the line into pieces using spaces

        int[] numbers = new int[10];                     // Create array for 10 numbers
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = Convert.ToInt32(parts[i]);      // Convert each piece to an integer
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine("\nMaximum number: " + max);
        Console.WriteLine("Minimum number: " + min);
    }
}
