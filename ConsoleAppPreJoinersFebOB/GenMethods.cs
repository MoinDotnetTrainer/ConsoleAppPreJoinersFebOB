using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class GenMethods
    {
        public static void M1(int x, int y)  // datatype as a Parameter
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static int M2() {
            return 1;
        }

        // gen  methods uses type as a Pm , insted of Datatype


        public static void M3<type1>(type1 x)
        {
            Console.WriteLine(x);
        }

        public static void M3<type1,type2>(type1 x , type2 y) {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static void M3<type1, type2,type3>(type1 x, type2 y,type3 z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
