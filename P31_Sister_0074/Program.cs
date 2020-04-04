using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace P31_Sister_0074
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Irfan Nurahman || 18.11.0074 ==========");
            Console.WriteLine("mulai melakukan pekerjaan");
            Console.WriteLine("==================================================");

            Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));

            tid1.Start();
            tid2.Start();

            Console.ReadLine();
        }


        public class MyThread
        {
            public static void Thread1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("cuci baju ke {0}", i);
                    Thread.Sleep(3000);
                }
            }

            public static void Thread2()
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Setrika ke {0}", i);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
