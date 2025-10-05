using System;



   class Checker
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0) 
            Console.WriteLine("Number is Even");
        else
            Console.WriteLine("Number is Odd");

    }
    }

