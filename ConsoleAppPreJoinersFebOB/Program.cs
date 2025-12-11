using System;  //header file
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;
namespace ConsoleAppPreJoinersFebOB
{
    internal class Program
    {
        static async Task Main(string[] args)  // main method  entry point
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

            //refout obj = new refout();
            //(int x, string y) = obj.M3();
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //obj.M4(12, 2, out int Add, out int Sub);
            //Console.WriteLine(Add);
            //Console.WriteLine(Sub);

            //obj.Exe();

            //Sample obj = new Sample();
            //obj.Test();


            //try
            //{
            //    Prop obj = new Prop();
            //    obj.x_ = 34;  // <=50
            //    obj.y_ = 344;  // <=50
            //    obj.Add();
            //}
            //catch (Exception x)
            //{
            //    Console.WriteLine(x.Message);
            //}


            /*try
            {
                Index_Ex obj = new Index_Ex();
                obj[0] = -10;
                obj[1] = 657;
                obj[2] = 2563;
                //obj[3] = 2563;
                //obj[4] = 2783;
                //obj[5] = 253;
                Console.WriteLine(obj[0]);
                Console.WriteLine(obj[1]);
                Console.WriteLine(obj[2]);

                //Console.WriteLine(obj[3]);
                //Console.WriteLine(obj[4]);
                //Console.WriteLine(obj[5]);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            */

            //GenMethods.M1(12, 34);
            //GenMethods.M3<int, int>(23, 3);  // during the call
            //GenMethods.M3<string, int>("Test", 34);


            //GenericClass<int, int> obj = new GenericClass<int, int>();
            //obj.M1(34, 45);
            //obj.M2(34, 45);
            //obj.M3(34, 45);
            //obj.M4(34, 45);
            //obj.M5(34, 45);

            // collections 

            //  Collections.hashset();
            //   Console.WriteLine("--");
            //   Collections.ArraysList();

            // MultiTasking obj = new MultiTasking();


            // main method is a single threaded app 

            // multiple sub thread

            //Thread t1 = new Thread(obj.M1);
            //t1.Start();

            // Thread t2 = new Thread(obj.M2);
            // t2.Start();




            //WordWithoutAsync obj1 = new WordWithoutAsync();


            //Task t = new Task(obj1.GetFile1);
            //t.Start();
            //t.Wait();
            //Console.ReadLine();

            //   refout.Test();



            /*call1 c1 = new call1(Delegate_Ex.Add);  // it can call a method 
            c1.Invoke();

            call1 c2 = new call1(Delegate_Ex.Sub);  // it can call a method 
            c2.Invoke();

            call2 c3 = new call2(Delegate_Ex.Mul);  // it can call a method 
            c3.Invoke(23, 3);

            call2 c4 = new call2(Delegate_Ex.Div);  // it can call a method 
            c4.Invoke(23, 3);



            // multi cast

            call1 mc = new call1(Delegate_Ex.Add);  // it can call a method 
            mc += (Delegate_Ex.Sub);
            mc.Invoke();
            */



            // two types of delegates 
            // single , multi cast

            /* MyDelegate del = delegate (string msg)
             {
                 Console.WriteLine("Anonymous method says: " + msg);
             };
             del.Invoke("hi");

             call1 myex = delegate ()
             {
                 Console.WriteLine("test");
             };
             myex.Invoke();


             call1 res = () =>
             {
                 Console.WriteLine("lamds method with 0 arg");
             };
             res.Invoke();

             // using lamba expression

             MyDelegate lamdaex = (string msg) =>
             {
                 Console.WriteLine(msg);
             };
             lamdaex.Invoke("lamba method ex");

             annomous.greet("test");

             */

            //  Console.WriteLine(annomous.isPositive(-34));

            LinqExamples obj = new LinqExamples();
            obj.Test1();
        }
    }
}
