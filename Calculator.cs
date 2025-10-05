using System;


	class Calculator
	{
	static void Main()
	{
		double num1 , num2 , result;
		char operations;
        Console.WriteLine("Enter first number :");
	     num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number :");

        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n Enter the Operation");
            Console.WriteLine("\n + : Addition");
            Console.WriteLine("\n - : Subtraction");
            Console.WriteLine("\n * : Multiplication");
            Console.WriteLine("\n / : Division");
            Console.WriteLine("\n  Enter Your choice :");

        operations = Convert.ToChar(Console.ReadLine());
		switch(operations) {
			case '+':
				result = num1 + num2;
				Console.WriteLine($"Result: {num1} + {num2} = {result}");
				break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;

             case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
  
              case '/':
                result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                break;
        }
	}
}
