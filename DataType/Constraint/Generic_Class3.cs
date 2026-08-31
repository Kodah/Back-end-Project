using System;

class Program
{
    interface IManager<T>
    {
        void Add(T item);
        void Print(T item);
    }

    enum EmployeeStatus
    {
        Active = 1,
        OnLeave = 0,
        Terminated = -1
    }

    class Employee
    {
        public int Id;
        public string Name;
        public EmployeeStatus Status;
    }

    class EmployeeManager : IManager<Employee>
    {
        public void Add(Employee item)
        {
            Console.WriteLine("Employee added successfully.");
        }

        public void Print(Employee item)
        {
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"Name: {item.Name}");

            switch (item.Status)
            {
                case EmployeeStatus.Active:
                    Console.WriteLine("Status: Employee is active.");
                    break;

                case EmployeeStatus.OnLeave:
                    Console.WriteLine("Status: Employee is on leave.");
                    break;

                case EmployeeStatus.Terminated:
                    Console.WriteLine("Status: Employee is terminated.");
                    break;
            }
        }
    }

    static void Main()
    {
        Employee employee = new Employee
        {
            Id = 1,
            Name = "Omar",
            Status = EmployeeStatus.Terminated
        };

        EmployeeManager manager = new EmployeeManager();

        manager.Add(employee);
        manager.Print(employee);
    }
}
