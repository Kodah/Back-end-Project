using System;

class Program
{
    class student : person
    {
    }
    class Teacher : person
    {
    }
    class person
    {
        public string name;
        public int age;
        public long id;
        public void PrintWorking()
        {
            Console.WriteLine($"My name's {name}, Im working..");
        }
    }
    static void Main()
    {
        student student = new student
        {
            name = "Omar",
            age = 23,
            id = 32120001017
        };
        Teacher teacher = new Teacher
        {
            name = "Luffy",
            age = 22,
            id = 32220001073
        };
        
        Console.WriteLine(student.name);
        Console.WriteLine(student.age);
        Console.WriteLine(student.id);

        Console.WriteLine("------------*-----------");

        Console.WriteLine(teacher.name);
        Console.WriteLine(teacher.age);
        Console.WriteLine(teacher.id);

        Console.WriteLine("------------*-----------");

        student.PrintWorking();
        teacher.PrintWorking();
    }
}
