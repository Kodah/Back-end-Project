using System.Security.Cryptography;

// Copier Constructer

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

    public Student(Student copy)
    {
        Name = copy.Name;
        Age = (int)copy.Age;
    }

    

    static void Main() 
    {
        Student St1 = new Student("omar",22);
        Student St2 = new Student(St1);

        Console.WriteLine("Student1:");
        Console.WriteLine(St1.Name);
        Console.WriteLine(St1.Age);

        Console.WriteLine();

        Console.WriteLine("Student2:");
        Console.WriteLine(St2.Name);
        Console.WriteLine(St2.Age);



    }
}
