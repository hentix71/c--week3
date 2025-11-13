namespace Test2;
class NullOperations
{
    public void PerformNullChecks()
    {
        string? username = null;
        string output = (username == null ? "Null" : username);
        Console.WriteLine($"From Ternary: {output}");
    }

    public void NullCoalesingOne()
    {
        string username = null;
        string outputOne;

        outputOne = username ?? "Ayush";
        username ??= "Ayush";

        Console.WriteLine(outputOne);
        Console.WriteLine(username);

    }
}