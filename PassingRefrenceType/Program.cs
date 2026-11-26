namespace PassingRefrenceType
{
    internal class Program
    {
        static void Main()
        {
            cls1 o = new cls1();
            o.i = 1;
            DoSomething1(o);
            DoSomething2(ref o);
            DoSomething3(out o); // object int cannot convert obj into object
            DoSomething4(in o);
            DoSomething4(o);
            Console.WriteLine(o.i);

        }

        public static void DoSomething1(cls1 o)
        {
            o.i= 2;
            Console.WriteLine(" do something ");
        }
        public static void DoSomething2(ref cls1 o)
        {
            o = new cls1();
            o.i = 3;
            Console.WriteLine(o.i);
        }
        public static void DoSomething3(out cls1 o)
        {
            o = new cls1();
            o.i = 4;
            Console.WriteLine(o.i);
        }
        public static void DoSomething4(in cls1 o)
        {
            //o = new cls1(); no need
            o.i = 5;
            Console.WriteLine(o.i);
        }

    }
    public class cls1
    {
        public int i;
    }
}
