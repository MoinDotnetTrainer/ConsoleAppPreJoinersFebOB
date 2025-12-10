using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPreJoinersFebOB
{
    internal class WordWithoutAsync
    {
        public static int Exe(string filename)
        {
            int lenth = 0;
            using (StreamReader sr = new StreamReader(filename))
            {
                string actualdata = sr.ReadToEnd();
                lenth = actualdata.Length;  // no of words
                Task.Delay(4000).Wait();
            }
            return lenth;
        }

        public void GetFile()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes dotnet.txt";
            int words = Exe(filename);
            Console.WriteLine("Task1");  // not block
            Console.WriteLine("Task2");  // block
            Console.WriteLine("Task3");  // block
            Console.WriteLine("no of words:" + words);  // this is taking time
            Console.WriteLine("Task4");
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");

        }

        public static async Task<int> Exe1(string filename)
        {
            int lenth = 0;
            using (StreamReader sr = new StreamReader(filename))
            {
                string actualdata = await sr.ReadToEndAsync();
                lenth = actualdata.Length;  //holds this exe without blocking others
                Task.Delay(4000).Wait();
            }
            return lenth;
        }

        public async void GetFile1()
        {
            string filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes dotnet.txt";
            Task<int> words = Exe1(filename);
          
            Console.WriteLine("Task1");  // not block
            Console.WriteLine("Task2");  // block
            Console.WriteLine("Task3");  // block
            int length = await words;

            Console.WriteLine("no of words:" + length);  // this is taking time
            Console.WriteLine("Task4");
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");

        }
    }
}
