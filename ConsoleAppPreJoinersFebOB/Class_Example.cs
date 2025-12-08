using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class Class_Example
    {
        public int Add(int x, int y)  // 12 ,2
        {
            int z;
            z = x + y;
            Console.WriteLine("Add is :" + z); // 91 , dynamic result
            return z;   // 14
        }
        public int sub(int x, int y)
        {
            int z;
            z = x - y;
            Console.WriteLine("sub is :" + z);
            return z;
        }
        public void mul()
        {
            int x = 45, y = 46, z;
            z = x * y;
            Console.WriteLine("mul is :" + z); //1
        }
        public void Div()
        {
            int x = 45, y = 46, z;
            z = x / y;
            Console.WriteLine("Div is :" + z);
        }
    }
}
