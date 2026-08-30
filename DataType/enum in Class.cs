
class Progam
{
    public static void Main()
    {
        Employee employee = new Employee()
        {
            Name = "Omar",
            Status = EmployeeStatus.Suspended
        };

        employee.CheckStatus();
    }

    interface IEmployeeCheckStatus
    {
        void CheckStatus();
    }
    enum EmployeeStatus
    {
        Active = 1,
        OnLeave = 2,
        Suspended = 3,
        Terminated = 4
    }

    class Employee : IEmployeeCheckStatus
    {
        public string Name { get; set; }
        public EmployeeStatus Status { get; set; }

        public void CheckStatus()
        {
            switch (Status)
            {
                case EmployeeStatus.Active:
                    Console.WriteLine($"{Name} is Active");
                    break;

                case EmployeeStatus.Suspended:
                    Console.WriteLine($"{Name} is Suspended");
                    break;

                case EmployeeStatus.OnLeave:
                    Console.WriteLine($"{Name} is OnLeave");
                    break;

                case EmployeeStatus.Terminated:
                    Console.WriteLine($"{Name} is Terminated");
                    break;

                default:
                    Console.WriteLine($"{Name} is Unknown Status");
                    break;
            }
        }

    }
}
