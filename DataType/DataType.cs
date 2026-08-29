int Num = 515;
long Lg = 100000000000;
float FT = 19.99f;
double DBL = 19.999;
char Char = 'A';
DateTime HBD = DateTime.Now;
bool IsMale = true;
decimal Dec = 20.05m;
String St1 = "Hello Guys.";

struct StudentInfo
{
    public int StudentID;
    public string StudentName;

}

enum Colors
{
    Red,
    Green,
    Blue
}

public class Program
{
    public static void Main()
    {
        Person p1 = new Person("Mohammad");
        Person p2 = p1;

        int x = 1;
        int y = x;
    }
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

}
