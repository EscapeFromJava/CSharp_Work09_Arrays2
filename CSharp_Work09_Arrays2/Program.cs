using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Work09_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            Random rand = new Random();
            int[] arr = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
                arr[i] = rand.Next(-15,15);
            foreach (int el in arr)
                Console.WriteLine(el);
            Console.WriteLine("===================");
            Array.Sort(arr, drop);
            foreach (int el in arr)
                Console.WriteLine(el);
            Console.WriteLine("===================");
            Array.Sort(arr, chet);
            foreach (int el in arr)
                Console.WriteLine(el);

            Console.ReadKey();
        }
        static int drop(int x, int y)
        {
            if (x < y)
                return 1;
            return -1;
        }
        static int chet(int x, int y)
        {
            if (x % 2 == 0)
                return -1;
            if (x % 2 != 0 && y % 2 != 0)
                if (x < y)
                    return -1;
            return 1;
        }
    }
}
