namespace HideOverRideOverLoad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            //DerivedClass d = new DerivedClass();
            // d.Display1();
            // d.Display1("aa");
            // d.Display2();
            // d.Display3();

            //--------------------------------------------------
            BaseClass b;
            b = new BaseClass();
           // b.Display2(); // non-virtual, early bound (compile time binding)
            b.Display3(); // virtual, late bound(run time binding)

            Console.WriteLine();

            b= new DerivedClass();
           // b.Display2();// non-virtual, early bound (compile time binding)
                         //for early bounding, function called depends on the referance

            b.Display3();// virtual, late bound (run time binding)
            //for late bounding, function called depends on the object (memory allocated)

            b = new SubDerivedClass();
            b.Display3();
            Console.WriteLine();

            b = new SubSubDerivedClass();
            b.Display3();
        
        }

        static void Main1(string[] args)
        {
           BaseClass o1= new BaseClass();
            DerivedClass o2= new DerivedClass();
            CallDisplay3(o1);
            CallDisplay3 (o2);
        }
        static void CallDisplay3(BaseClass o)
        {
            o.Display3();
        }
    }

    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }

    }
    public class DerivedClass : BaseClass
    {
        //overload
        public void Display1(string s)
        {
            Console.WriteLine("derived Display1");
        }

        //hiding
        public new void Display2()
        {
            Console.WriteLine("derived Display2");
        }

        //override
        public override void Display3()
        {
            Console.WriteLine("derived Display3");
        }

    }
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subderived display3");
        }
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("SubSubDerived display3");
        }
    }
}