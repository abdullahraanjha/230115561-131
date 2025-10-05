using System;


	class ReverseNumber
	{
    static void Main()
    {
        Console.Write("Enter a number to be Reversed : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;
        while (num != 0)
        {
            int digit = num % 10;
            reversed = (reversed * 10) + digit;
            num = num / 10;
        }
        Console.WriteLine("The reversed number is : " + (reversed));
	}

}
