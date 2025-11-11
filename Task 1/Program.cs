using Test1;

namespace Task1;

class Program
{
    public static void Main(string[] args)
    {
        Operators op = new Operators();
        op.Add(10, 10);
        op.Subtraction(20, 10);
        op.Multiply(10, 2);
        op.Divide(20, 2);
        op.Multiply(20, 2);
        op.OddEvenFinder(39);
    }
}
