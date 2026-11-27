using System;
namespace Annonymous_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<string ,string> obj = Display; //normal func call using func
            //Console.WriteLine(obj(" string")); ;

            Func<int, int, int> obj = delegate (int x, int y) { return x + y; };
            Console.WriteLine(obj(10,20));

            Func <string , string> obj1 = delegate (string s) { return s; };
            Console.WriteLine(obj1("string"));

        }
        static string Display(string s)
        {
            Console.WriteLine("display called");
            return s;
        }
    }
}
