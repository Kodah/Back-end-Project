using System.Security.Cryptography;

// Static Constructer

class Student
{
    public static string SchoolName;
    public Student(string name)
    { 
        Console.WriteLine("Construct Created!");
        Console.WriteLine("Student:" + name);
    }   

    static Student()
    {
        SchoolName = "Al-Balqa'a Applied University";
        Console.WriteLine("Construct Static Created!");
    }

    static void Main() 
    {
        Console.WriteLine("Creating 1st Student:");
        Student st1 = new Student("Mohammed");

        Console.WriteLine();

        Console.WriteLine("Creating 2nd Student:");
        Student st2 = new Student("Omar");

        Console.WriteLine();

        Console.WriteLine("School Name:" + Student.SchoolName);



    }
}
