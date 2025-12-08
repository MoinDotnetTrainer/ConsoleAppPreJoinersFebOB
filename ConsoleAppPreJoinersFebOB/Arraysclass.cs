using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class Arraysclass
    {
        public void Arrays_example()
        {
            int x = 67;// single memory allocation
            int[] arr = { 345, 45, 65, 765, 7, 86, 8 };
            // index 0
            Console.WriteLine(arr[0]);
            string[] strings = { "Hi", "Hello" };
            Console.WriteLine(strings[0]);
            float[] floats = { 23.4f, 45.56f };
            Console.WriteLine(floats[0]);

            int[] x1 = { 435, 456 };
            int[] x2 = new int[5] { 435, 45, 67, 56, 78 };

            // ? --> nullable [] --> array
            // int

            // datatypes 
            // readline , convertion , parsing , boxing , unboxing , implict ,explict , nullable ,arrays
            // stack heap 

        }
    }
}
