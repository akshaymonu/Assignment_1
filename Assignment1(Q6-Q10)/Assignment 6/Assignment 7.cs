using System;

public class ConsoleAPP
{
	private static bool isPrime(int num)
	{
		for (int i = 2; i <= num / 2; i++)
		{
			if (num % i == 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void Main()
	{
		int num;
		Console.WriteLine("Enter the number to check : ");
		num = int.Parse(Console.ReadLine());

		if (isPrime(num))
		{
			Console.WriteLine("{0} is a prime number", num);
		}
		else
		{
			Console.WriteLine("{0} is not a prime number", num);
		}
	}
}
