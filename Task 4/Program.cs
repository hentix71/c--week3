namespace Task4;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter From 1-7");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Sunday"); break;
            case 2: Console.WriteLine("monday"); break; 
            case 3: Console.WriteLine("Tuesday"); break;
            case 4: Console.WriteLine("wed"); break;
            case 5: Console.WriteLine("Thur"); break; 
            case 6: Console.WriteLine("Fri"); break;
            case 7: Console.WriteLine("Sat");  break;
            default: Console.WriteLine("Invalid Choice"); break;
        }
    }
}