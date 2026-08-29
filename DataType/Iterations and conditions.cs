int x = 15;

if (x >= 0)
    {
        Console.WriteLine("x is bigger");
    }
else
    {
        Console.WriteLine("x is samller");
    }

int counter = 0;

for (int y=0;y<=10;y++)
    {
    counter = counter + y;
    }
Console.Write("The Counter after Sum: ");
Console.WriteLine(counter);

string[] Names = { "3amoorah", "Luffy", "Alghazo", "Rababa'h", "Smadi", "Derar" };
foreach(string names in Names)
{
    Console.WriteLine(names);
}

while(x < 20)
{
    Console.Write("The number is: ");
    Console.WriteLine(x);
    x++;
}

int K = 3;
do
{
    Console.Write("K after +1: ");
    Console.WriteLine(K);
    K++;
} while (K <= 9);

