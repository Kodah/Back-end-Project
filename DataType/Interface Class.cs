class Program
{
    public static void Main()
    {
        Student student = new Student("Omar", 23, DateTime.Now);

        student.StudentName();
        student.StudentAge();
        student.StudentBD();
        student.IsWorking();
    }

    public class Student : IInfo, IWork
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }

        public Student(string name, int age, DateTime BD)
        {
            Name = name;
            Age = age;
            BirthDay = BD;
        }

        public void StudentName()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void StudentAge()
        {
            Console.WriteLine("Age: " + Age);
        }

        public void StudentBD()
        {
            Console.WriteLine("BirthDay: " + BirthDay);
        }

        public void IsWorking()
        {
            Console.WriteLine(Name + " Is Working..");
        }

    }
    interface IInfo
    {
        void StudentName();
        void StudentAge();
        void StudentBD();
    }
    
    interface IWork
    {
        void IsWorking();
    }
}
