namespace RefandValie2
{
    internal class Program
    {
        static void Main()
        {
            int i = 10, j = 20; //for using ref variable should be assign with some value
            Init(out i, out j);
            Swap(ref i, ref j);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine("using in readonly ");
            Console.WriteLine(i);
        }
        static public void Swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static public void Init(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
        static public void Print(in int x)
            {
            Console.WriteLine(x);
            }

    }
}
