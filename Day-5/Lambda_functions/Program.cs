namespace Lambda_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string,string> obj = (string s) => s;
            Console.WriteLine(obj("string called using lambda"));
        }
    }
}
