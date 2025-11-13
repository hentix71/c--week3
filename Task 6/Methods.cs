using System.ComponentModel;

namespace Task6;

class Methods
{
    public void TryCatch()
    {
        Console.Write("Enter a number:");
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Invalid Number format {ex}");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }

    public void PasswordStrength()
    {
        Console.Write("Enter Password:");
        string? password = Console.ReadLine();
        if (password == null || password.Length < 6)
        {
            throw new Exception("Password is less then 6");
        }
        else
        {
            Console.WriteLine("Suitable Password");
        }
    }
}