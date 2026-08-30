
// Sealed Class
sealed class Names
{
    public string Name;

    public Names(string name)
    {
        Name = name;
    }

    public void PersonInfo()
    {
        Console.WriteLine("The Name is:" + Name);
    }
}
    
class Program
{
    static void Main()
    {
        Names Name = new Names("Derar");

        Name.PersonInfo();
        
    }
        
}
