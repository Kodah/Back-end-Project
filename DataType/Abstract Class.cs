
// Abstract Class

    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The Animal Is Eating...");
        }

        public abstract void MakeSound();

    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Says: WOOF!");
        }
    }
    

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Eat();
        dog.MakeSound();
    }
        
}
