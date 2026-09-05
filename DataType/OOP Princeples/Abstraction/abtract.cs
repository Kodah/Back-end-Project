class Program
{
    abstract class Animal
    {
       public string Name {  get; set; }

       public abstract void MakeSound();
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(" Mewo!");
        }
    }
    static void Main()
    {
        Cat cat = new Cat()
        {
            Name = "I'm Cat."
        };

        Console.Write(cat.Name);
        cat.MakeSound();
        
    }
}
