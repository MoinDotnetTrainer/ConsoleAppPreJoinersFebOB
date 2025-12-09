using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class Parent
    {
        public int x, y, z;
        public void Add()
        {
            z = x + y;
            Console.WriteLine("Add is:" + z);
        } // a scope ends here
    } // class ends here
    class Child : Parent
    {
        public int a;
        public void Sub()
        {
            Add();
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
    }

    class Child1 : Parent
    {
        public void mul()
        {

            z = x * y;
            Console.WriteLine("Mul is:" + z);
        }
    }
    class Child2 : Parent
    {
        public void Div()
        {
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }
    }
}
