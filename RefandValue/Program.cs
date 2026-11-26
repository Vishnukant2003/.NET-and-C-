namespace RefandValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            cls1 o1 = new cls1();
            cls1 o2 = new cls1();

            o1.i = 100;
            o2.i = 200;
            o1 = o2;  //o1 is pointing to the o2 there for o1.i = 300 
            o2.i = 300; //02.i updated to 300
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);

            int o3 , o4 ;
            o3 = 100;
            o4 = 200;
            o3 = o4;
            o4 = 300;
            Console.WriteLine(" value type ");
            Console.WriteLine(o3);
            Console.WriteLine(o4);

            string o5 , o6;
            o5 = "100";
            o6 = "200";
            //o6 = o5;
            o5 = o6;
            o5 = "300";
            Console.WriteLine(" ref by with string follow exception for ref type ");
            Console.WriteLine(o5);
            Console.WriteLine(o6);

        }
    }
    public class cls1
    {
        public int i = 0;
    } 
}
