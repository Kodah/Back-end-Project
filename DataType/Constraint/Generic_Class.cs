using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Box<int> Intbox = new Box<int>();
        Box<string> StBox = new Box<string>();
        Box<Employee> EmployeeBox = new Box<Employee>();

        Intbox.Value = 23;
        StBox.Value = "LuffyEpstien";
        EmployeeBox.Value = new Employee()
        {
            Name = "AboodTown",
            Age = 54
        };

        Intbox.PrintValue();
        StBox.PrintValue();
        Console.WriteLine($"The Name: {EmployeeBox.Value.Name}, The Age: {EmployeeBox.Value.Age}");
        
    }

    class Box<T> : Iprintable
    {
        public T Value { get; set; }

        public Box() { }

        public void PrintValue()
        {
            Console.WriteLine($"The Value: {Value}");
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee() { }

    }

    interface Iprintable
    {
        void PrintValue();
    }
}
