using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    static class staticclass_Ex // no object
    {
        static staticclass_Ex() // parameters
        {
            Console.WriteLine(" one default const");
            // this static const is alwsys parameter less
        }
        public static void Add()
        {
            Console.WriteLine("Add");
        }
    }
}
