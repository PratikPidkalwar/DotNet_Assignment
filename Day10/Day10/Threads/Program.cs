namespace Threads
{
    internal class Program
    {
        static void Main1()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2= new Thread(Func2);
            t2.Start();

            for(int i = 0; i < 1; i++) {
                Console.WriteLine("Main: "+i);
            }
        }

        static void Main2()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.IsBackground = true;
            t2.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main: " + i);
            }
        }

        static void Main3()
        {
            Thread t1=new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2=new Thread(Func2);
            t2.Start();

            for( int i = 0;i < 100; i++)
            {
                Console.WriteLine("Main: " + i);
            }
            t1.Join();
            Console.WriteLine("This code should run only after func1 is over");
        }
        static void Main4()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Priority = ThreadPriority.Highest;

            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Priority = ThreadPriority.Lowest;
            t2.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }

        static void Main5()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));

            t1.Start();

            //t1.Abort();
            //t1.Suspend();
            //t1.Resume();


            //if(t1.ThreadState == ThreadState.)

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Main6()
        {

            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
                Thread.Sleep(1000);
            }
        }

        static void Main7()
        {
            AutoResetEvent wh=new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for(int i = 0;i < 200; i++)
                {
                    Console.WriteLine("f1: " + i);
                    if (i % 50 == 0)
                    {
                        //instead of suspend,use this
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }
            });
            t1.Start();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 1....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 2....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 3....");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resuming 4....");
            wh.Set();
        }

        static void Func1()
        {
            for(int i=0; i<100; i++)
            {
                Console.WriteLine("First: "+i);
                //Thread.Sleep(1000);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second: " + i);
                //Thread.Sleep(1000);
            }
        }
    }
}

namespace ParameterThread
{
    internal class Program
    {
        static void Main001()
        {
            //Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t1=new Thread(new ParameterizedThreadStart(Func1));

            int x = 10;
            t1.Start(x);

            Thread t2 = new Thread(Func2);
            string s = "passed value";
            t2.Start(s);

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i);
            }
            
        }
        //TO DO : PASS MULTIPLE VALUES TO THE FUNC
        //1 - create an array/collection. pass it
        //2 - create a class/struct with properties. pass an object of the class/struct
        //3 - write an anon method/ local funct. anon/loc func can access outer variables directly


        static void Func1(object obj)
        {
            int x = (int)obj;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i + x);
            }
        }
        static void Func2(object obj)
        {
            string s = obj.ToString();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second : " + i + s);
            }

        }
    }
}


namespace ThreadingExample3
{
    class MainClass
    {
        static void PoolFunc1(object o)
        {
            for(int i = 0;i < 100; i++)
            {
                Console.WriteLine("First thread"+i.ToString()+o.ToString());
            }
        }
        static void PoolFunc2(object o1)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First thread" + i.ToString());
            }
        }

        static void Main()
        {
            ThreadPool.QueueUserWorkItem(PoolFunc1,"aaa");
            ThreadPool.QueueUserWorkItem(PoolFunc2);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main: " + i.ToString());
            }

            int workerThreads, ioThreads;

            ThreadPool.GetAvailableThreads(out workerThreads, out ioThreads);

            ThreadPool.SetMaxThreads(workerThreads, ioThreads);
                Console.WriteLine(workerThreads);
                Console.WriteLine(ioThreads);

            Console.ReadLine();



        }
    }

   


}