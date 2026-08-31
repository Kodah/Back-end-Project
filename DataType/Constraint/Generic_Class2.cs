using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        DisplayService displayService = new DisplayService();

        displayService.Dislplay(true); // Boolean
    }
    public class DisplayService
    {
        public void Dislplay<T>(T Value)
        {
            Console.WriteLine($"The Value: {Value}");
            Console.WriteLine($"The Type Of Value: {Value.GetType().Name}");
        }
            
        
    }
}
