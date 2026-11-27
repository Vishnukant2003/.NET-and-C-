using System;
namespace Delegate_action_func_predicate_
{   
    internal class Program
    {
        //public delegate int Del1(int x, int y);
        //public delegate void  Del2();
        static void Main(string[] args)
        {
            //Del1 obj1 = Add;
            //Console.WriteLine(obj1(10,20));

            //Del2 obj = Display;
            //obj();

            Action ob = Display2;
            ob();

            Func<int, int, int> o = Add2;
            Console.WriteLine(o(10, 20));

            Func<string> oString = GetDateTime;
            Console.WriteLine(oString());

            Func<int, int> oDouble = Doubleval;
            Console.WriteLine(oDouble(10));

            Func<int, bool> o2 = IsEven;
            Console.WriteLine(o2(10));

            Predicate<Employee> oBasic = BasicIsGreater;
            Console.WriteLine(oBasic(new Employee {Basic = 11000})); //true

        }
        static void Display()
        {
            Console.WriteLine("display called");
        }
        static int Add(int a , int b)
        {
            return a + b;
        }
        static void Display2()
        {
            Console.WriteLine("display called using action method ");
        }
        static int Add2(int a, int b)
        {
            return a + b;
        }
        static string GetDateTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int Doubleval(int a)
        {
            return a * 2;
        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
        static bool BasicIsGreater(Employee emp)
        {
            return emp.Basic > 10000;
        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }

    }
}
