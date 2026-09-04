using System;

class Program
{

    interface Ifather
    {
        void Money();
    }

    interface Imother
    {
        void Hair();
    }

    class SON : Imother, Ifather
    {
        public void Money()
        {
            Console.WriteLine("I have Money from my father.");
        }
        public void Hair()
        {
            Console.WriteLine("My hair like the type of My mother's hair.");
        }
    }
    static void Main()
    {
        SON son = new SON();

        son.Money();
        son.Hair();
    }

}
