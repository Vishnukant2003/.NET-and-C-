using System.Globalization;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.Write("enter a integer -> ["+ i +"] : ");
                //Console.WriteLine($"enter a integer {i} : ");
                Console.WriteLine("enter a value [{0}] :"+ i); // 0 is the starting index
                arr[i] = Convert.ToInt32(Console.ReadLine()!);
                //arr[i] = int.Parse(Console.ReadLine()!);
            }
            foreach(int i in arr)
            {
                Console.Write(" "+i+" ");
            }

        }
        static void Main2()
        {
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            int pos = Array.IndexOf(arr, 30); //-1 if not found if found +ve value it returns
            pos = Array.LastIndexOf(arr, 30); //-1 if not found 
            pos = Array.BinarySearch(arr, 30); //negative if not found and positive if found

            //Console.WriteLine($"found at {pos}");

            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(i);
            }
            Array.Clear(arr); //reinitialise to def values
            foreach(int i in arr)
            {
                Console.Write(" "+i+" ");

            }
            Array.Copy(arr2, arr, arr.Length); //source,dest
            foreach (int i in arr)
            {
                Console.WriteLine(" copy array 2 into array1 " + i + " ");

            }
            Array.ConstrainedCopy(arr, 0, arr2, 0, arr.Length);//source,start, dest,start, length

            Array.Sort(arr);
            Console.WriteLine("sorted array --> ");
            foreach (int i in arr)
            {
                Console.Write(" " + i + " ");

            }
            Array.Reverse(arr);
            Console.WriteLine(" Reversed array " );

            foreach (int i in arr)
            {
                Console.Write(" " + i + " ");

            }

        }
        public static void Main()
        {
            int[,] arr = new int[3, 4];
            //arr[0,0] arr[0,1] arr[0,2] arr[0,3]
            //arr[1,0] arr[1,1] arr[1,2] arr[1,3]
            //arr[2,0] arr[2,1] arr[2,2] arr[2,3]

            Console.WriteLine($"no of dimensions : {arr.Rank}");
            Console.WriteLine($"length : {arr.Length}");
            Console.WriteLine($"length of 1st dimension : {arr.GetLength(0)}");
            Console.WriteLine($"length of 2nd dimension : {arr.GetLength(1)}");
        }

    }
}
