using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class StaticMethod
    {
        public static void Add() // static method , bcoz am  using static keyword
        {
            int x = 45, y = 35, z;
            z = x + y;
            Console.WriteLine("Add is :" + z); // 91 , dynamic result
        }
        public static void Sub()
        {
            int x = 45, y = 35, z;
            z = x - y;
            Console.WriteLine("sub is :" + z); // 91 , dynamic result
        }
        public void mul()  // non static 
        {
            int x = 45, y = 35, z;
            z = x * y;
            Console.WriteLine("mul is :" + z); // 91 , dynamic result
        }
    }
}
