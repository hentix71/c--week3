using System.Numerics;

namespace Test1;

public class Operators
{
	public void Add(int a, int b)
	{
		Console.WriteLine($"Addition {a + b}");
	}

	public void Subtraction(int a, int b)
	{
		Console.WriteLine($"Difference {a - b}");
	}

	public void Multiply(int a, int b)
	{
		Console.WriteLine($"Multiply {a * b}");
	}
	public void Divide(int a, int b)
	{
		Console.WriteLine($"Division {a/b}");
	}

	public void OddEvenFinder(int number)
	{
		String output = ((number % 2 == 0) ? "Even " : "Odd");
		Console.WriteLine($"The number is: {output}");
	}
}