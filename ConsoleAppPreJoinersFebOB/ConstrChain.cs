using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class ConstrChain
    {
        public ConstrChain() { Console.WriteLine("Default"); }

        public ConstrChain(int x):this(12,34) { Console.WriteLine("1 int"); }

        public ConstrChain(string str) { Console.WriteLine("1 string"); }

        public ConstrChain(int x, int y) { Console.WriteLine("2 int Pm"); }
    }

    class ConstrChainChild : ConstrChain
    {
        public ConstrChainChild():base(45) { Console.WriteLine("Child"); }
    }
}
