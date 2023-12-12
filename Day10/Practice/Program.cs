using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Thread t1 = new Thread(new ThreadStart(Func1));
            //Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            Thread t1 = new Thread(Func1);

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            t1.Start(arr);

            Thread t2 = new Thread(Func2);
            //List<string> list = new List<string>();


            var list = new List<string>() { "p", "Q", "R", "s", "T" };
            t2.Start(list);

            Thread t3 = new Thread(Func3);
            int a = 10; 
            int b = 20;
            /*
                        Class1 class1 = new Class1();
                        class1.P1 = a;
                        class1.P2 = b;*/
            t3.Start(new Class1() {P1 = a,P2 = b}); // using object initializer 

            String s = "Pratik";
            

            Thread t4 = new Thread(delegate (Object o)
            {
                String str = o.ToString();
                Console.WriteLine("anony : " + str);

                for(int i=0; i<10; i++)
                {
                    Console.WriteLine("last anony : " + i);
                }

            });
            t4.Start(s);

        }
        //TO DO : PASS MULTIPLE VALUES TO THE FUNC
        //1 - create an array/collection. pass it
        //2 - create a class/struct with properties. pass an object of the class/struct
        //3 - write an anon method/ local funct. anon/loc func can access outer variables directly


        static void Func1(Object obj)
        {
            int[] arr = (int[])obj;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("First arr: " + i + " " + arr[i]);
            }
        }
        static void Func2(Object obj)
        {
            var list = (List<string>)obj;
            foreach (string item in list)
            {
                Console.WriteLine("Second List string: " + item + " ");
            }
        }

        /*//class Unboxing
        static void Func3(Object obj)
        {
            Class1 cls = (Class1)obj;

            Console.WriteLine("In func 3 : " + (cls.P1 + cls.P2));

        }*/

        static void Func3(Object obj)
        {

            Class1 cls = (Class1)obj;
            Console.WriteLine("In func 3 : " +( cls.P1 + cls.P2));

        }

    }
    public class Class1
    {
        public int P1 { get; set; }
        public int P2 { get; set; }

        public void Display()
        {
            Console.WriteLine("Display: "+P1 + " " + P2);
        }
    }
}
