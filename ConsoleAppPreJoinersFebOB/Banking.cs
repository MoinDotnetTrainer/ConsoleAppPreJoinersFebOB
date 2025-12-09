using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    abstract class Banking // sector
    {
        // abstrct methods 
        public abstract void Withdraw(); // only decleration
        public abstract void Deposite(); // only decleration

        public void M1() { } // run --> object of banking 
        public virtual void M2() { }  // run this with object , or i can override
        public static void M3() { }  // class name 
        public Banking() { }  // object 
    }

    class HDFC : Banking
    {
        public override void Withdraw() { } // only decleration
        public override void Deposite() { } // only decleration
    }

    abstract class Vehicle
    {
        public abstract void Break();
        public abstract void Gear();
    }
}
