using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    static class staticclass // no object creation 
    {
        public static int Add(int x, int y)  // to access add --> object
        {
            int z;
            z = x + y;
            Console.WriteLine("Add is :" + z); // 91 , dynamic result
            return z;   // 14
        }
        public static int sub(int x, int y)
        {
            int z;
            z = x - y;
            Console.WriteLine("sub is :" + z);
            return z;
        }
        public static void mul()
        {
            int x = 45, y = 46, z;
            z = x * y;
            Console.WriteLine("mul is :" + z); //1
        }
        public static void Div()
        {
            int x = 45, y = 46, z;
            z = x / y;
            Console.WriteLine("Div is :" + z);
        }
    }
}
