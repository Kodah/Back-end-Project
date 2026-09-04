using System;

class Program
{
    
    class Car 
    {

        public virtual void PrintMotorInfo()
        {
            Console.WriteLine("Car");
        }

    }

    class BMW : Car
    {
        public override void PrintMotorInfo()
        {
            Console.WriteLine("BMW Cost 10K");
        }

    }

    class Mercedes  : Car 
    {
        public override void PrintMotorInfo()
        {
            Console.WriteLine("Mercedes Cost 8K");
        }

    }

    static void Main()
    {
        Car car = new Car();
        BMW bmw = new BMW();
        Mercedes M = new Mercedes();

        car.PrintMotorInfo();
        bmw.PrintMotorInfo();
        M.PrintMotorInfo();

    }
}
