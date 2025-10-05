using System;

class SearchElement
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nEnter the number you want to search: ");
        int searchNum = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        // Linear Search
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] == searchNum)
            {
                found = true;
                break; // stop searching once found
            }
        }

        if (found)
            Console.WriteLine($"\n{searchNum} exists in the array!");
        else
            Console.WriteLine($"\n{searchNum} does NOT exist in the array.");
    }
}
