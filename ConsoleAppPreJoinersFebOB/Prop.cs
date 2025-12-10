using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{

    class Index_Ex
    {
        private int[] Age = new int[3];  // no of 3 and index range _ve values

        // indexers 

        // this keyword
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Age");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }
            }
            get
            {
                return Age[index];
            }

        }
    }

    class Prop_Ex
    {
        public int x { get; set; }  // compressed

        private int y;  // full syntax
        public int y_
        {
            get { return y; }
            set { y = value; }
        }
    }






    internal class Prop
    {

        // y private , y not public
        // reusing a var from one class to another class
        // x , y , all other class 

        // we make use of properties

        private int x;  // variable
        public int x_  // prop
        {
            set
            {
                if (value > 50 || value < 0)
                {
                    throw new ArgumentException("Value is not correct");
                }
                else
                {
                    x = value;
                }
            }

            get { return x; }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value > 50 || value < 0)
                {
                    throw new ArgumentException("Value is not correct");
                }
                else
                {
                    y = value;
                }
            }
        }

        public void Add()
        {
            int z = x + y;  // 50 + 50 = 100
            Console.WriteLine("Add is:" + z);
        }


    }
}
