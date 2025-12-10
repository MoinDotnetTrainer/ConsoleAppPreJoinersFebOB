using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{

    class Interns
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public bool Status { get; set; }
    }
    internal class Collections
    {
        public static void List()
        {
            List<string> lss = new List<string>();
            lss.Add("Apple");

            List<int> ls = new List<int>();  // length is dynmaic
            ls.Add(43);
            ls.Add(345);
            ls.Add(45363);
            ls.Add(4673);
            ls.Add(4453);
            ls.Add(4653);
            ls.Add(4563); ls.Add(43);
            ls.Add(345);
            ls.Add(45363);
            ls.Add(4673);
            ls.Add(4453);
            ls.Add(4653);
            ls.Add(4563);
            ls.Add(43);
            ls.Add(123);
            ls.Add(45363);
            ls.Add(4673);
            ls.Add(4453);
            ls.Add(4653);
            ls.Add(4563);
            ls.Add(433);
            ls.Add(4343);
            ls.Add(4543);
            ls.Add(45);

            ls.RemoveAt(0);  // index
            ls.Remove(123);
            ls.Insert(0, 100);


            foreach (int item in ls)
            {
                Console.WriteLine(item);
            }



            //int[] arr = { 24, 456, 6, 5675 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


        }
        public static void hashset()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(34);
            hs.Add(23);
            hs.Add(54);
            hs.Add(78);
            hs.Add(89);
            hs.Add(6);
            hs.Add(34);
            hs.Add(23);
            hs.Add(54);
            hs.Add(78);
            hs.Add(89);
            hs.Add(6);
            hs.Add(3674);
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
        public static void Sortedset()
        {
            SortedSet<int> ss = new SortedSet<int>();  // disoplay items in assending
            ss.Add(34);
            ss.Add(3476);
            ss.Add(6);

            ss.Add(89);
            ss.Add(879);
            ss.Add(879);
            ss.Add(879);
            ss.Add(89);
            ss.Add(34);
            ss.Add(3476);
            ss.Add(6);

            ss.Add(89);
            ss.Add(879);
            ss.Add(879);
            ss.Add(879);
            ss.Add(89);
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }

        }
        public static void Quque()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(23);
            q.Enqueue(56);
            q.Enqueue(69);
            q.Enqueue(2893);
            q.Enqueue(67);
            q.Enqueue(28693);
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
        public static void stack()
        {
            Stack<int> st = new Stack<int>();
            st.Push(25);
            st.Push(34);
            st.Push(3432);
            st.Push(3465);
            st.Push(253);
            st.Push(123);
            st.Pop();

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }

        public static void ListClass_Ex()
        {
            List<Interns> obj = new List<Interns>() {
            new Interns{ Sno=1,Name="Xyz",Email="xyz@yahoo.com",Gender="Male",Status=true},
            new Interns{ Sno=2,Name="test",Email="test@yahoo.com",Gender="Male",Status=true},
            new Interns{ Sno=3,Name="sam",Email="sam@yahoo.com",Gender="Female",Status=true},
            new Interns{ Sno=4,Name="abc",Email="abc@yahoo.com",Gender="Male",Status=true},
            };

            foreach (var item in obj)
            {
                Console.WriteLine($"Id is {item.Sno} and name is {item.Name}");
            }
        }

        public static void ArraysList() {   // Non genric
            ArrayList al = new ArrayList();
            al.Add(23);
            al.Add("test");
            al.Add(true);
            al.Add(23.45);
            al.Add(23);
            al.Add(23);
            al.Add(23);
            al.Add(23);
            al.Add(23);
            al.Add(23);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

        }

    }
}
