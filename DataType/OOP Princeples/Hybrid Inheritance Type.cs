class Program
{
    class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }

    class Teacher : Person
    {
        public void Teach()
        {
            Console.WriteLine("Teacher is teaching");
        }
    }

    class Programmer : Student
    {
        public void Code()
        {
            Console.WriteLine("Programmer is coding");
        }
    }
    static void Main()
    {
        Programmer programmer = new Programmer();

        programmer.Name = "Omar";

        programmer.Introduce();
        programmer.Study();
        programmer.Code();

        Teacher teacher = new Teacher();

        teacher.Name = "Mohammed";

        teacher.Introduce();
        teacher.Teach();
    }
}
