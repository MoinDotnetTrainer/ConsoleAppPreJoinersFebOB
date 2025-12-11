using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class refout
    {
        public void M1()
        {
            Console.WriteLine("No");
        }
        public int M2()
        {
            return 1;
        }

        public (int, string) M3()
        {
            return (12, "Hi");
        }

        public void M4(int x, int y, out int Add, out int sub)
        {
            Add = x + y;
            sub = x - y;
        }


        public void Cal(ref int x)  // x add will be overrided with y add
        {
            x = x + 10;
            Console.WriteLine("X is :" + x);  // 20
        }

        public void Exe()
        {
            int y = 10;
            Console.WriteLine("Print y Before :" + y);  // 10
            Cal(ref y);  // call by values
            Console.WriteLine("Print y after :" + y);  // 20
        }

        public static void Test() {
            string input = "123";
            int number;

            bool success = int.TryParse(input, out number);

            if (success)
            {
                Console.WriteLine($"Conversion successful: {number}");
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }
        }
    }
}
