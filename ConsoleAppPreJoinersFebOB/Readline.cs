using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class Readline
    {
        public void Readline_Ex()
        {
            int x = 3456;  // static values or hardcoded

            // dynamic values

            Console.WriteLine("Enter ur name");
            string Username = Console.ReadLine();   // readline accepts input from user at runtime
            // lhs == rhs
            // readline scanf
            Console.WriteLine(Username);

            Console.WriteLine("Enter Byte value ");
            byte b = Convert.ToByte(Console.ReadLine());  // 123 --> "123"
            // convertion technique while one type to another type

            Console.WriteLine("Byte values is :" + b);

            Console.WriteLine("enter int values");
            int x_ = Convert.ToInt32(Console.ReadLine());
            // 4 > 255 = 1 0-255
            Console.WriteLine("int value is :" + x_);

            // value type vs ref type datatype
            //  stack & heap
            //  whose lenth is fixed they are value type
            // whose length is not fixed they are ref type
            // int float , double decimal  --> value type
            // string object --> ref

            // converting a variable from value to ref type ---> boxing
            // converting a variable from ref to value type ---> unboxing

            int x1 = 435;
            string str1 = x1.ToString(); // boxing
            int x2 = Convert.ToInt32(str1);  // unboxing


            int a = 45;
            object o = a; // boxing
            int a1 = (int)o;  // unboxing

            // stack & heap 
            // values in stack
            // ref in heap



            // implict & explict 
            // auto & manually
            // lower to higher is implict
            // higher to lower is explict

            byte b1 = 45;
            int b2 = b1;  // implict

            int b3 = 4356;
            byte b4 = (byte)b3;  // explict
            Console.WriteLine("b4 is :" + b4);  // what b4 will display


            // nullables in c#
            // values type will not hold null values directly
            int? d1 = null;  // d1 is value
            Nullable<int> d3 = null;
            string d2 = null;  // d2 is ref



        }
    }
}
