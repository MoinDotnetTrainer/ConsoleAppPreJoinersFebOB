using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MyDelegate(string message);

namespace ConsoleAppPreJoinersFebOB
{
    class annomous
    {
        public static Action<string> greet = delegate (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        };

        public Func<int, int, int> multiply = delegate (int a, int b)
        {
            return a * b;
        };
        public Func<string, string, int> getname = delegate (string a, string b)
        {
            if (a == "xyz")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        };

        Func<string> getMessage = () => "Hello from Func";


        public static Predicate<int> isPositive = delegate (int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        };
    }
}
