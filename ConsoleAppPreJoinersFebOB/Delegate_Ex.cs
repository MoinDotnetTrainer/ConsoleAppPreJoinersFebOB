using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void call1();  // to create a delegate
public delegate int call2(int x , int y);

namespace ConsoleAppPreJoinersFebOB
{
    internal class Delegate_Ex
    {
        public static void Add()    // object
        {
            int x = 45, y = 46, z;
            z = x + y;
            Console.WriteLine("Add is:"+z);
        }

        
        public static void Sub()
        {
            int x = 45, y = 46, z;
            z = x - y;
            Console.WriteLine("sub is:" + z);
        }

        public static int Mul(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
            return z;

        }
        public static int Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
            return z;
        }
    }
}
