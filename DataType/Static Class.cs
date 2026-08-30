
// Static Class

static class Calculator
{
    
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    
}

class Program
{
    static void Main()
    {
        int result1 = Calculator.Add(3, 19);
        int result2 = Calculator.Multiply(5, 13);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}
