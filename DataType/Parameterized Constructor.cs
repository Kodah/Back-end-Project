using System.Security.Cryptography;

class Student
{
    public string Name;
    public int Age;
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        
        Console.WriteLine("Construct Created!");
    }

    static void Main()
    {
        Student St = new Student("Omar", 23);
        Console.WriteLine(St.Name);
        Console.WriteLine(St.Age);

    }
}
