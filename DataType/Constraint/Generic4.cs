public class Program
{
    public static void Main()
    {
        Box<int> numberBox = new Box<int>();
        numberBox.SetValue(100);

        Box<string> nameBox = new Box<string>();
        nameBox.SetValue("Mohammad");

        Console.WriteLine(numberBox.GetValue());
        Console.WriteLine(nameBox.GetValue());
    }
}

public class Box<T>
{
    private T _value;

    public void SetValue(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}
