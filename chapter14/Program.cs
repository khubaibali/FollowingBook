using System;
using System.Threading;

namespace chapter14
{
    class Temp
    {
        public Temp()
        {
            Console.WriteLine("Class temp");
        }
    }
    class MainClass
    {
        public static void func1()
        {
            int max = 1000;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Func1 loop " + i);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Func2 loop "+i);
            }
        }

        public static void threadArr(int temp)
        {
            Console.WriteLine(temp);
        }

        public static void Go()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("?");
            }
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Multi Threading Concepts");
            //Thread t = new Thread(func1);
            //Thread t2 = new Thread(Func2);
            //Thread t3 = new Thread(Go);
            ////t.Start();
            ////Thread.Sleep(10000); // it delayed for 10 seceonds
            ////t.Join();           //another thread start after thread one has finished working
            ////t2.Start();

            //t3.Start();
            //Go();


            //for (int i = 0; i < 10; i++)
            //new Thread(() => Console.Write(i)).Start();




            //for (int i = 0; i < 100; i++)
            //{
            //    int temp = i;
            //    new Thread(() => Console.WriteLine(temp)).Start();  //thread will start to print inderministic time

            //}

            //Console.WriteLine("Application Ended");



            Console.ReadLine();

        }
    }
}
