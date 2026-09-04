using System;

class Program
{
    class GrandFather
    {
        public decimal Money;
        public string land;
    }

    class Father : GrandFather
    {
        public string Car;
        public long Number;

    }

    class Son : Father
    {
        public string Name;
        public int age;

        public void PrintSon()
        {
            Console.WriteLine($"My Name's is {Name},I'm {age} years old, I take from " +
                $"Father a land and More Money.");

        }

    }

    static void Main()
    {
        Son son = new Son
        {
            Name = "Luffy",
            age = 22
        };

        son.PrintSon();
    }
}
