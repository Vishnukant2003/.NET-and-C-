namespace ParamsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Add( 10,30,40)); //allowed
            Console.WriteLine(Add(10,20,30,30,40));
        }
        //public static int Add(  int a, params int[] arr) //allowed
        public static int Add( params int[] arr) //allowed

        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
