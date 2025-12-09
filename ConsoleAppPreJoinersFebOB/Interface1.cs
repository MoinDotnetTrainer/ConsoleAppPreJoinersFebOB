using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    interface Interface1
    {
        void M1();  // abstrct 
        void M2();
    }

    interface Interface2
    {
        void M3();  // abstrct 
    }
    abstract class Class3
    {
        public abstract void M5();
        public void M4()
        {
            Console.WriteLine("M4 from class3");
        }
    }

    class Class4
    {
        public void M6()
        {
            Console.WriteLine("M6 from class4");
        }

    }

    class OneChild : Interface2, Interface1
    {
        public void M1() { }  // abstrct 
        public void M2() { }
        public void M3() { }
    }
}
