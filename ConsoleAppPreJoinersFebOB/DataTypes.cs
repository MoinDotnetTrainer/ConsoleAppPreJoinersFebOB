using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace ConsoleAppPreJoinersFebOB
{
    internal class DataTypes
    {
        public void Datatypes_example()
        {
            // interger 0-9
            // byte  short  int  & long
            // 1    2       4       8
            // byte --> byte & sbyte
            // short --> short ushort


            // 1 byte --> 8 bits ==> 0-255 or -128 +127 

            //variabe of byte type

            byte b = 255;  //  unsigned only + values
            sbyte sb = -128;  // singned +-

            Console.WriteLine("byte values is :" + b);
            Console.WriteLine("sbyte values is :" + sb);

            //floating 0.00
            //float double & decimal

            float f = 45.56f;  // double
            double d = 34.34;
            decimal dm = 45.456m;
            Console.WriteLine("Float sttau values is :" + f);

            bool status = false;
            Console.WriteLine("status value is :" + status);


            char c = 'A';
            Console.WriteLine("Ini is :" + c);

            string str = "Welcome";
            Console.WriteLine("string is :" + str);


            // other categories of datatypes

            // var , dynamic and object --> they can hold any values


            // var is compile time , value type
            var v = 243;// integer , int
            v = 4;
            v = 567;
            v = 67;
            //v = true;

            var v1 = "Hi hello";
            v1 = "test";
            var v3 = 45.45;
            var res = v3 + v;
            var v4 = true;


            // dynamic and object runtime datatype
            dynamic d1 = 45;  // compiler d1 as int
            d1 = "string";
            d1 = true;

            dynamic d2 = "hi";
            dynamic d3 = 34.45;
            dynamic d4 = 34.56;

            dynamic res1 = d3 + d4;



            // A+B;

            object o1 = 234;
            o1 = 45.45;
            object o2 = 345.456;
            object o3 = "hi";
            object o4 = true;
            object reso = (int)o1 + (int)o2; // type casting , object are ref as string , ref type






        }
    }
}
