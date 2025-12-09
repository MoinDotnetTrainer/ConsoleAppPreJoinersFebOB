using System;  //header file
using ClassLibrary1;
namespace ConsoleAppPreJoinersFebOB
{
    internal class Program
    {
        static void Main(string[] args)  // main method  entry point
        {
            //Console.WriteLine("Hello, World!");

            //writeline function like printf 

            //console --> class

            //Emp obj = new Emp(); // creating an object of emp
            //obj.Empdetails(); // calling a method

            //Students std = new Students();
            //std.StdDetails();

            //DataTypes obj = new DataTypes();
            // obj.Datatypes_example(); // importing , invoking 

            //Readline obj = new Readline();
            //obj.Readline_Ex();

            // Parsing obj = new Parsing();
            //obj.Parsing_Ex();

            // Arraysclass obj = new Arraysclass(); // realtime entity
            //obj.Arrays_example();

            // human being --> person

            /*Class_Example obj = new Class_Example();
             int res = obj.Add(12, 2);
             if (res == 14)
             {
                 Console.WriteLine("if block");
             }
             else
             {
                 Console.WriteLine("Els block");
             }
             int myres = obj.sub(12, 2);
             obj.mul();
             obj.Div();
            */

            // StaticMethod.Add();
            // StaticMethod.Sub();

            // StaticMethod obj = new StaticMethod();
            //obj.mul();

            // again m again no need of creating object


            // MethodOverloading.M1("12");

            //ConstrExample obj = new ConstrExample();
            //obj.Add();

            // staticclass_Ex.Add();

            // ConstrExample obj = new ConstrExample(12);  // explict am calling the const

            // staticclass_Ex.Add();

            // MethodsWithOptnl.Add(y:12,x:2);  // x= 12 , y = 2
            // MethodsWithOptnl.M1(13);

            // Parent p = new Parent();
            // p.Add();
            //Child c = new Child();
            //c.x = 46;
            //c.y = 78;
            //c.Sub();
            //c.Add();

            //RBIBank obj = new RBIBank();
            //obj.Withdraw();
            //obj.Deposite();
            //obj.EmpInfo();
            //obj.EmpSal();

            //Banking.M3();

            //PartialEx p = new PartialEx();
            //p.M1();

            // Orders o = new Orders();
            //o.M1();
            //o.M2();
            //o.M3();

            // OrdersTest.M3(o,23,43);

            //Debugging.M1();
            //  Debugging.M2();


            //  ConstrChainChild c = new ConstrChainChild();

            //MathOPerations obj = new ClassLibrary1.MathOPerations();
            //obj.ScientificCali();
            //obj.Calculator();

            // ExeceptionHandling obj = new ExeceptionHandling();
            // obj.Test();

            refout obj = new refout();
            (int x, string y) = obj.M3();
            Console.WriteLine(x);
            Console.WriteLine(y);
            obj.M4(12,2,out int Add, out int Sub);
            Console.WriteLine(Add);
            Console.WriteLine(Sub);

            obj.Exe();
        }
    }
}
