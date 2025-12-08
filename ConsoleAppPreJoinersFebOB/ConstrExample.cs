using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class ConstrExample
    {
        public void Add() {  // method 
            Console.WriteLine("add method");
        }


        // const name is same as class name
        // no retun type
        // exe auto during obj creation
        public ConstrExample() {   // default const
            Console.WriteLine("constr is getting  exe");
        }


        public ConstrExample(int x)
        {   // const
            Console.WriteLine("1 constr is getting  exe");
        }

        public ConstrExample(string str)
        {   // const
            Console.WriteLine("2 constr is getting  exe");
        }
    }
}
