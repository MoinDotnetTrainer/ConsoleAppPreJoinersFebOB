using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class Const
    {
        // const and readonly --> variables
        const int x = 89;
        readonly int y;

        public Const()
        {
            y = 23;
        }
        public void add()
        {
            // value cannot be modified

            Console.WriteLine(x); // 89
        }

        public void sub()
        {

        }


    }
}
