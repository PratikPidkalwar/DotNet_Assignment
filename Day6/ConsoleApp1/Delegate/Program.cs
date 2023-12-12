using System;

namespace Delegate1
{
    internal class Program
    {
        //STEP 1: Create a delegate class having the same signature as the function to call.
        public delegate void Del1();
        public delegate int Del2(int a, int b);
        //Object
        //Delegate
        //MultiCastDelegate
        //Del1
        static void Main1(string[] args)
        {
            //STEP 2: create a delegate object and make the delegate referance point to the object.
            //        the object will contain the function to call as a parameter.
            Del1 oDel = new Del1(Display);
            
             

            //STEP 3:Call the function with Delegate referance 
            oDel();
        }
        //static void Display()
        //{
        //    Console.WriteLine("Display");
        //}

        static void Main2(string[] args)
        {
            //STEP 2: create a delegate object and make the delegate referance point to the object.
            //        the object will contain the function to call as a parameter.
            Del1 oDel = Display;


            //STEP 3:Call the function with Delegate referance 
            oDel();

            oDel = Show;
            oDel();
        }

        //Multitask Delegate


        static void Main(string[] args)
        {
            //STEP 2: create a delegate object and make the delegate referance point to the object.
            //        the object will contain the function to call as a parameter.
           // Del1 oDel = Display;
            

            //oDel=Delegate.Combine(new )
            Del1 oDel=(Del1)Delegate.Combine(new Del1(Display),new Del1(Show));
            Del2 del2 = (Del2)Delegate.Combine(new Del2(Add), new Del2(Sub));


            oDel = (Del1)Delegate.Remove(oDel, new Del1(Display));
            oDel=(Del1)Delegate.RemoveAll(oDel, new Del1(Display));
            //STEP 3:Call the function with Delegate referance 
            oDel();
             del2 = Add;
            Console.WriteLine(del2(12,10));
            del2 = Sub;
            Console.WriteLine(del2(12, 2));

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine();
            oDel += Show;
            oDel();

            Console.WriteLine();
            oDel += Display;
            oDel();


            Console.WriteLine();
            oDel -= Display;
            oDel();

            Console.WriteLine();
            oDel -= Display;
            oDel();

            Console.WriteLine();
            oDel += Display;
            oDel();

           
            
        }
        static void Display()
        {
            Console.WriteLine("Display");
        }

        static void Show()
        {
            Console.WriteLine("Show");
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }

        static string Name(string n1,string n2)
        {
            return n1+","+n2;
        }
    }
}