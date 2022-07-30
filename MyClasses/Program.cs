using MyClassLibrary;

namespace MyClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyClasses.Models.Namespace1.Abc obj1 = new MyClasses.Models.Namespace1.Abc();
            MyClasses.Models.Namespace2.Abc obj2 = new MyClasses.Models.Namespace2.Abc();
            obj1.func();
            obj2.func();
            Greetings greetings = new Greetings(10);
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{greetings[i].Id} {greetings[i].Name}");
            }
                
        }
    }
}