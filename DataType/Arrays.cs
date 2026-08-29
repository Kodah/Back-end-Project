// ------------ Task #1 ------------

int[] arr = [90, 10, 60, 5];

int[] original = (int[])arr.Clone();

foreach(int i in arr)
{
    Console.WriteLine(i);
}

Console.WriteLine();

// ------------ Task #2 ------------

Console.WriteLine($"The length of array is: {arr.Length}");
Console.WriteLine();

// ------------ Task #3 ------------

Array.Sort(arr);
foreach(int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// ------------ Task #4 ------------

Array.Reverse(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// ------------ Task #5 ------------

Array.Sort(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// ------------ Task #6 ------------

Array.Clear(arr,0,2);
foreach(int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// ------------ Task #7 ------------

for(int i=0; i< arr.Length;i++)
{
    Console.WriteLine($"The index {i} = {arr[i]}");
}

// ------------ Task #8 ------------

Console.WriteLine("Index Of 90: " + Array.IndexOf(arr, 90));

// ------------ Task #9 ------------

public class Program
{
    public static void Main()
    {
        Person[] persons = new Person[2];
        persons[0] = new Person
        {
            Name = "Omar",
            Age = 23
        };

        persons[1] = new Person
        {
            Name = "Luffy",
            Age = 22
        };

        foreach(Person person in persons)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

    }

    public class Person()
    {
        public String Name {  get; set; }

        public int Age { get; set; }
    }
}
