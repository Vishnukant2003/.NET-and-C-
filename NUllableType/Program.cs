

namespace NUllableTypes
{
    internal class Program
    {
        static void Main()
        {
            int? i;
            i = 100;
            i = null;

            int j;
            if (i != null)
                j = (int)i;
            else
                j = 0;

            if (i.HasValue)
                j = i.Value;
            else
                j = 0;

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(10);
            j = i ?? 0; //null coalesence operator

            Console.WriteLine(j);
        }

        static void Main2()
        {
            //nullable reference type

            string s;
            s = Console.ReadLine()!; //single line suppress
            s = Console.ReadLine();


            string? s2;
            s2 = Console.ReadLine();
            s2 = Console.ReadLine();
        }
    }
}