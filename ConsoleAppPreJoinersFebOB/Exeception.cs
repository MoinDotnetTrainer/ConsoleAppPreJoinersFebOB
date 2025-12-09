using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class ExeceptionHandling
    {
        public void Test()
        {
        a:
            try
            {
                Console.WriteLine("Enter x");
                int x = Convert.ToInt32(Console.ReadLine()); // xyz

                Console.WriteLine("Enter y");
                int y = Convert.ToInt32(Console.ReadLine());  // xyz

                int z = x / y;  // y=0
                Console.WriteLine("Div :" + z);

                string[] str = { "hi" };
                Console.WriteLine(str[10]);  // error 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("format");
                Console.WriteLine(ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("divide");
                Console.WriteLine(ex.Message);
                goto a;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index");
                Console.WriteLine(ex.Message);
                goto a;
            }

            catch (Exception ex)
            {
                Console.WriteLine("format");
                Console.WriteLine(ex.Message);
                goto a;
            }
        }
    }
}
