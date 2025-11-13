namespace Task5;
class Methods
{
    public void SumNumber()
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        int output = 0;
        for (int i = 0; i <= number; i++)
        {
            output += i;
        }
        Console.WriteLine($"The sum of till the {number} is {output}");
    }
    public void PrintNumbers()
    {
        Console.WriteLine("Enter number for prinitng:");
        int number = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        while (number == 0 ? false : (i <= number ? true : false))
        {
            if (i == 15)
            {
                break;
            }

            if (i % 4 == 0)
            {
                i++;
                continue;
            }
            Console.WriteLine($"Number : {i}");
            i++;
        }
        
    }

    public void SumForEach()
    {
        Console.Write("Enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        while (n > 0 )
        {
            Console.Write("Enter Int value for array:");
            array[n-1] = Convert.ToInt32(Console.ReadLine());
            n--;
        }

        int sum = 0;
        foreach(int i in array)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of the array is {sum}");
    }
}