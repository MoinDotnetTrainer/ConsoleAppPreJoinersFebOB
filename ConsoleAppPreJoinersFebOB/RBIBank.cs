using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    class RBIBank
    {
        // Withdraw 
        // Deposite
        // EMp Info
        // Emp Sal 

        public virtual void Withdraw()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" Withdraw details from RBI");
        }
        public virtual void Deposite()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" Deposite details from RBI");
        }
        public void EmpInfo()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" EmpInfo details from RBI");
        }
        public void EmpSal()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" EmpSal details from RBI");
        }
    }

    class SBI : RBIBank
    {
        // Withdraw 
        // Deposite
        public override void Withdraw()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" Withdraw details from SBI");
        }

        public new void EmpInfo()
        {
            // SOme logic to withdraw money from rbi
            //100+ lines of code is written
            Console.WriteLine(" EmpInfo details from SBI");
        }

    }
}
