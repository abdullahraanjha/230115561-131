using System;



	class Factorial { 
       static void Main()
	{
        Console.Write("Enter a number to find its factorial : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        int factorial = 1;
        while (i <=num)
        {
            factorial = factorial * i;
            i++;
        }
        Console.WriteLine("The factorial of the entered number is : " + (factorial));
        
            
        }


        
            
        }
    
