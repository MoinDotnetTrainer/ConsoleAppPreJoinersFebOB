using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class Parsing
    {
        public void Parsing_Ex()
        {

            //Console.WriteLine("Enter AGe");
            //int age = Convert.ToInt32(Console.ReadLine());  // convertion tech
            //byte b = Convert.ToByte(Console.ReadLine());
            //char c = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Given age is:"+age);

            //int age1= int.Parse(Console.ReadLine());  // parsing
            //byte b1= byte.Parse(Console.ReadLine());
            //char c1= char.Parse(Console.ReadLine());

            // one type to another type
            // what is the diff

            string str = null;
            int x1 = Convert.ToInt32(str);  // 0 , accepts null while converting
            Console.WriteLine(x1);
            int x2 = int.Parse(str);  // error ,, will not accepts null
            Console.WriteLine(x2);

            
        }
    }
}
