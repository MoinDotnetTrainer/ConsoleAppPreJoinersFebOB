using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppPreJoinersFebOB
{

    class Std
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? Gender { get; set; }
        public bool? status { get; set; }
    }

    class Users
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? status { get; set; }
    }
    class LinqExamples
    {
        public void Test()
        {
            // linq 2 diff dyntax 
            // 1. query
            // 2. method

            int[] arr = { 34, 45, 565, 6, 76, 7, 87, 8, 9, 89, 0, 90, };


            // 1. query syntax

            var res = from s in arr where s > 50 select s;

            var methodsyntax = arr.Where(x => x > 50);


            foreach (var item in methodsyntax)
            {
                // only numbers >50
                // Console.WriteLine(item);
            }


            List<Std> std = new List<Std>() {
            new Std{ ID=1,Name="xyz",Gender="Male",status=true},
            new Std{ ID=2,Name="Sam",Gender="Female",status=true},
            new Std{ ID=3,Name="anu",Gender="Female",status=true},
            new Std{ ID=4,Name="priya",Gender="Female",status=true},
            new Std{ ID=5,Name="raj",Gender="Male",status=false},
            new Std{ ID=6,Name="varma",Gender="Male",status=false},
            };

            var mystd = from s in std where s.status == true select s;// all records
            foreach (var item in mystd)
            {
                // Console.WriteLine($"Id is {item.ID} and name is {item.Name} gender is {item.Gender} and status is {item.status}");
            }

            var mystd1 = from s in std
                         where s.Gender == "Male"
                         select new
                         {
                             Name = s.Name,
                             Gender = s.Gender
                         };

            foreach (var item in mystd1)
            {
                //  Console.WriteLine($" name is {item.Name} gender is {item.Gender} ");
            }

            int[] arr1 = { 34, 45, 565, 6, 76, 7, 87, 8, 9, 89, 0, 90, 34, 45, 565, 6, 76, 7, 87, 8, 9, 89, 0, 90 };

            var max = (from s in arr1 select s).Count();
            // Console.WriteLine(max);

            object[] o = { 12, 45, 6, true, false, "Hi", "hello" };
            var intvalues = o.OfType<bool>();
            foreach (var item in intvalues)
            {
                //  Console.WriteLine(item);
            }

            var dis = (from s in arr1 select s).Distinct();
            foreach (var item in dis)
            {
                Console.WriteLine(item);
            }


        }

        public void Test1()
        {
            int[] arr = { 23, 4, 54, 55, 6, 76, 787, 9, 8, 121, 123 };
            int[] arr1 = { 45, 56, 67, 6, 87, 88, 9, 0990, 23, 4, 54, 55, 6, 76, 787, 9, 8 };
            var union = (from s in arr select s).Union(arr1);  // get the from two or more , elemenates duplicate

            var concat = (from s in arr select s).Concat(arr1);

            var Intersect = (from s in arr select s).Intersect(arr1);
            var Except = (from s in arr select s).Except(arr1);
            foreach (var item in Except)
            {
                // Console.WriteLine(item);
            }

            int[] obj = { 23, 4, 54, 55, 6, 76, 787, 9, 8, 121, 123 };
            // all any contains return bool values
            var allex = (from s in obj select s).All(x => x > 50);// 1 0
            var anyex = (from s in obj select s).Any(x => x > 50);// 1 0
            var contains = (from s in obj select s).Contains(50);// 1 0
                                                                 // Console.WriteLine(contains); // false

            List<Users> users = new List<Users>() {
            new Users{ ID=1,Name="xyz",Email="xyz@yahoo.com",Password="true",status=true},
            new Users{ ID=2,Name="Sam",Email="sam@yahoo.com",Password="true",status=true},
            new Users{ ID=3,Name="anu",Email="anu@yahoo.com",Password="true",status=true},
            new Users{ ID=4,Name="priya",Email="priya@yahoo.com",Password="true",status=true},
            new Users{ ID=5,Name="raj",Email="raj@yahoo.com",Password="false",status=true},
            new Users{ ID=6,Name="varma",Email="varma@yahoo.com",Password="false",status=false},
            };


            var loginwithemail = (from s in users select s).All(x => x.Email == "xyz@yahoo.com" && x.Password == "false");
            var login = (from s in users select s).All(x => x.status == true);
            if (login)
            {
                //Console.WriteLine("login success");
            }
            else
            {
                //Console.WriteLine("Login fail");
            }


            int[] Elements = { 23, 4, 54, 55, 6, 76, 787, 9, 8, 121, 123, 50, 123 };
            string[] str = { "hi", "hello" };

            // var elementat = (from s in Elements select s).ElementAt(100);  // error
            var elementatordef = (from s in str select s).ElementAtOrDefault(100);
            if (elementatordef == null)
            {
                // Console.WriteLine("no index");
            }
            else
            {
                // Console.WriteLine(elementatordef);
            }

            //var first = (from s in Elements select s).FirstOrDefault(x => x < 0);  // error
            // Console.WriteLine(first);

            //var single = (from s in Elements select s).Single(x => x == 123);  // error
            //Console.WriteLine(single);



            int[] Take = { 23, 40, 54, 55, 6, 76, 787, 9, 8, 121, 123, 50, 123 };

            var tesk_ex = (from s in Take select s).Take(5);
            foreach (var item in tesk_ex)
            {
                //  Console.WriteLine(item);
            }

            var tesk_while = (from s in Take select s).TakeWhile(x => x > 10);  // till the cond is true
            foreach (var item in tesk_while)
            {
                //Console.WriteLine(item);
            }

            var skip_ex = (from s in Take select s).Skip(5);
            foreach (var item in skip_ex)
            {
                //Console.WriteLine(item);
            }

            var ship_while = (from s in Take select s).SkipWhile(x => x > 10);  // till the cond is true
            foreach (var item in ship_while)
            {
                //Console.WriteLine(item);
            }


            List<Users> orderby_ = new List<Users>() {
            new Users{ ID=1,Name="xyz",LastName="abc",Email="xyz@yahoo.com",Password="true",status=true},
            new Users{ ID=2,Name="Sam",LastName="aaa",Email="sam@yahoo.com",Password="true",status=true},
            new Users{ ID=3,Name="anu",LastName="xyz",Email="anu@yahoo.com",Password="true",status=false},
            new Users{ ID=4,Name="abc",LastName="xyz",Email="priya@yahoo.com",Password="true",status=true},
            new Users{ ID=5,Name="abc",LastName="aaa",Email="raj@yahoo.com",Password="false",status=true},
            new Users{ ID=6,Name="soni",LastName="abc",Email="varma@yahoo.com",Password="false",status=false},
            };

            var orderby_ex = from s in orderby_ orderby s.Name descending select s;
            foreach (var item in orderby_ex)
            {
                // Console.WriteLine(item.Name);
            }

            var thenby = orderby_.OrderBy(x => x.Name)
                .ThenBy(x => x.LastName);

            foreach (var item in thenby)
            {
                //Console.WriteLine($"Name is {item.Name} and lastname is {item.LastName}");
            }


            var groupby = from s in orderby_ group s by s.status;  // key status

            var lookByQS = (from std in orderby_
                            select std).ToLookup(x => x.status);
            // first will get key and then value

            //Console.WriteLine("Group by ex");
            foreach (var item in groupby)
            {
                // Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    //  Console.WriteLine($"Name is {data.Name} and lastname is {data.LastName}");
                }
            }

            // Console.WriteLine("Lookup ex");
            foreach (var item in lookByQS)
            {
                //Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    //Console.WriteLine($"Name is {data.Name} and lastname is {data.LastName}");
                }
            }


            List<Users> Immediate_ = new List<Users>() {
            new Users{ ID=1,Name="xyz",LastName="abc",Email="xyz@yahoo.com",Password="true",status=true},
            new Users{ ID=2,Name="Sam",LastName="aaa",Email="sam@yahoo.com",Password="true",status=true},
            new Users{ ID=3,Name="anu",LastName="xyz",Email="anu@yahoo.com",Password="true",status=false},
            new Users{ ID=4,Name="abc",LastName="xyz",Email="priya@yahoo.com",Password="true",status=true},
            new Users{ ID=5,Name="abc",LastName="aaa",Email="raj@yahoo.com",Password="false",status=true},
            new Users{ ID=6,Name="soni",LastName="abc",Email="varma@yahoo.com",Password="false",status=false},
            };

            var lazy = from s in Immediate_ where s.status == false select s;
            var imm = (from s in Immediate_ where s.status == false select s).Count();  // 2

            Immediate_.Add(new Users { ID = 7, Name = "test", LastName = "testing", Email = "varma@yahoo.com", Password = "false", status = false });




            Immediate_.Add(new Users { ID = 7, Name = "tests", LastName = "testing", Email = "varma@yahoo.com", Password = "false", status = false });

            foreach (var item in lazy)
            {
                // Console.WriteLine($"Name is {item.Name} ");   // anu soni test tests
            }
            //  Console.WriteLine(imm);  // 2



            int[] IEnum = { 23, 40, 54, 55, 6, 76, 787, 9, 8, 121, 123, 50, 123 };

            var res = from s in IEnum select s;
            IEnumerable<int> res1 = from s in IEnum where s > 50 select s;  // 

            IQueryable<int> iquery = IEnum.AsQueryable().Where(x => x > 50);  // kidney
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
