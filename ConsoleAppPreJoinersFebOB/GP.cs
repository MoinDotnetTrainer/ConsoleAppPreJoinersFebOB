using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class GP
    {
        public int x, y, z;
        public void M1() {
            Console.WriteLine("M1 from GP");
        }
    }

    class P  : GP
    {
        public void Cal() {
            z = x / y;
        }
    }


    class C : P
    {
        public void Test() {
            Cal();
            z = x * y;
        }
    }
}
