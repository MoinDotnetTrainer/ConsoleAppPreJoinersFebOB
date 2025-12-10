using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class MultiTasking
    {
        public void M1()
        {
            Console.WriteLine("M1");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M1:" + i); // blocked
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Event:" + i);  // other event
            }
        }

        public void M2()
        {
            Console.WriteLine("M2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M2:" + i);
            }
        }
    }
}
