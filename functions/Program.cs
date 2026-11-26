namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            derived1 o = new derived1();
            derived1 o1 = new derived1(10,20);
            o.virual_fun();


        }

    }
    public class Base 
    {
        public int i;
        public Base()
        {
       
            Console.WriteLine("base class constructor");
            i = 100;
        }
        public virtual void virual_fun()
        {
            Console.WriteLine("base_virtual_function");
        }
        public Base(int i)
        {
            Console.WriteLine("params constructor" + i);
            this.i= i;
        }
    }
    public class derived1 : Base 
    {
        public int j;
        public override void virual_fun()
        {
            Console.WriteLine("derive_virtual_function");
        }
        public derived1() 
        {

            Console.WriteLine("derived constructor-1");
            j = 10;
        }
        public derived1( int i,int j) : base(i)
        {
            this.i= i;
            this.j= j;
            Console.WriteLine("derived params constructore-2 "+i+" "+j);

        }
    }
    
}
