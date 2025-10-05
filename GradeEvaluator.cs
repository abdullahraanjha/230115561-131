using System;

class GardeEvaluator
{
    static void Main()
    {
        Console.WriteLine("Enter the Marks :");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 85)
        {
            Console.WriteLine("The Grade is A");
        }
        else if (number >= 70 && number <= 84 )
        {
            Console.WriteLine("The Grade is B");
        }
        else if (number >= 55 && number <= 69)
        {
            Console.WriteLine("The Grade is C");
        }
        else if (number >= 40 && number <= 54)
        {
            Console.WriteLine("The Grade is D");
        }
        else
        {
            Console.WriteLine("The Grade is F");
        }
    }
}
