using System.Security.Cryptography;

// Overloading Constructer

class Student
{
    public string Name;
    public int Age;
    public Student() // Constructer 1
    {
        Name = "Luffy";
        Age = 20;
        
        Console.WriteLine("Construct Created!");
    }

    public Student(string name) // Constructer 2
    {
        Name = name;
        Age = 33;
    }

    public Student (string name, int age) // Constructer 3
    {
        Name = name;
        Age = age;
    }

    static void Main() // print all of Constructers
    {
        Student St1 = new Student();
        Student St2 = new Student("Omar");
        Student St3 = new Student("Smadi",23);
        Console.WriteLine(St1.Name);
        Console.WriteLine(St1.Age);
        Console.WriteLine();
        Console.WriteLine(St2.Name);
        Console.WriteLine(St2.Age);
        Console.WriteLine();
        Console.WriteLine(St3.Name);
        Console.WriteLine(St3.Age);

    }
}
