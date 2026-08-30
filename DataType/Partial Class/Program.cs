using System;
    
class Program
{
    static void Main()
    {
        Student st = new Student();

        st.NameSt = "Amoorah";
        st.AgeSt = 10;

        st.printName();
        st.printAge();
        st.SayHello();
    }
        
}
