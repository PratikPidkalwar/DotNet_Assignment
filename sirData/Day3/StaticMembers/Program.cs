namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.s_Display();
            Class1 o2 = new Class1();
            Class1.s_i = 12345;
            Class1 o1;
            o1= new Class1();
            o1.i = 100;
            o1.P1 = 10;
            o1.Display();

            o2.i = 200;
            o2.Display();

            Class1.s_P1 = 20;

            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);
            Console.WriteLine(Class1.s_i);
            Console.WriteLine(Class1.s_P1);


        }
    }
    public class Class1
    {
        public int i;

        //only a single copy for the entire class (shared data)
        public static int s_i;

        public void Display()
        {
            Console.WriteLine("display called");
            Console.WriteLine(i);
            Console.WriteLine(s_i);

        }

        //static methods can be called directly from the class without creating an object of the class
        public static void s_Display()
        {
            Console.WriteLine("static display called");
            //from a static member you can only access static members directly.
            //to access a non static member you need to have an object reference
            //Console.WriteLine(i);  //error
            Console.WriteLine(s_i);
            Console.WriteLine(s_P1);

        }


        private int p1;
        public int P1
        {
            set
            {
                if (value <= 100)
                    p1 = value;
                else
                    Console.WriteLine("Invalid value for P1");
            }
            get
            {
                return p1;
            }
        }

        private static int s_p1;
        public static int s_P1
        {
            set
            {
                if (value <= 100)
                    s_p1 = value;
                else
                    Console.WriteLine("Invalid value for P1");
            }
            get
            {
                return s_p1;
            }
        }
        public Class1()
        {
            Console.WriteLine("non static cons called");
        }


        //implicitly private
        //paramterless
        //cannot be overloaded
        static  Class1()
        {
            Console.WriteLine(" static cons called");
            s_i = 123;
            s_P1 = 33;
        }

    }
}

//why create a static variable? - single copy
//why create a property? - validations
//why create a static property? - single copy with validations
//why create a constructor? - to initialize data members
//why create a static constructor?- to initialize static data members

//when is the static constructor called? - when the class is initialized

//when is the class initialized? - either when the first object of the class is created
//or when you access a static member for the first time

//static class
//can only have static members
//cannot be instantiated
//cannot be used as a base class

//to do - create a static class in lab


















