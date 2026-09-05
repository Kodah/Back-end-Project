public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Mohammad",
                Salary = 1000
            },

            new Employee
            {
                Id = 2,
                Name = "Omar",
                Salary = 1500
            },

            new Employee
            {
                Id = 3,
                Name = "Ahmad",
                Salary = 2000
            }
        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}
