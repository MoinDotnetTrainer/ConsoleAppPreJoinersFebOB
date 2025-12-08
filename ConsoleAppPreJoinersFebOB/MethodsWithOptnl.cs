using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class MethodsWithOptnl
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("x is :" + x);
            Console.WriteLine("y is :" + y);
            Console.WriteLine("add is :" + z);
        }

        public static void M1(int x, params int[] y) // parameter as an optional
        {
            Console.WriteLine(x);
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
           
        }
    }
}
