using System.Security.Cryptography;

// Original Class

class Student
{
    public string Name;
    public int Age;

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name of student: " + Name);
        Console.WriteLine("Age of student: " +  Age);
    }
}

class Program
{
    static void Main()
    {
        Student st = new Student("Omar",23);

        st.PrintInfo();
    }
}
