
// --------------- Task #1 ---------------

int x = 15;

if (x >= 0)
    {
        Console.WriteLine("x is bigger");
    }
else
    {
        Console.WriteLine("x is samller");
    }

Console.WriteLine();
// --------------- Task #2 ---------------

int counter = 0;

for (int y=0;y<=10;y++)
    {
    counter = counter + y;
    }
Console.WriteLine($"The Counter after Sum: {counter}");
Console.WriteLine();

// --------------- Task #3 ---------------

string[] Names = { "3amoorah", "Luffy", "Alghazo", "Rababa'h", "Smadi", "Derar" };
foreach(string names in Names)
{
    Console.WriteLine(names);
}

Console.WriteLine();
// --------------- Task #4 ---------------

while (x < 20)
{
    Console.WriteLine($"The number is: {x}");
    x++;
}


Console.WriteLine();
// --------------- Task #5 ---------------

int K = 3;
do
{
    Console.WriteLine($"K after +1: {K}");
    K++;
} while (K <= 9);

Console.WriteLine();
