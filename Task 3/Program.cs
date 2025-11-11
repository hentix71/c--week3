namespace Test3;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter you Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age<13)
        {
            Console.WriteLine("Child");
        }
        else if(age<19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }

    }
}