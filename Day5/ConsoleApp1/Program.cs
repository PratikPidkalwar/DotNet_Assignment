namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello, World!");
          Class1 o = new Class1();
            o.i = 100;
            //DoSomething1(o);
            //DoSomething2(o);
            //DoSomething3(ref o);
            //DoSomething4(out o);
            DoSomething5(in o);


            Console.WriteLine(o.i);
        }
        static void DoSomething1(Class1 obj)
        {
            //changes made in func (changing value of properties) is reflected in calling code o
            obj.i = 200;
        }

        static void DoSomething2(Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is NOT reflected in calling code o            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething3(ref Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is reflected in calling code o
            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething4(out Class1 obj)
        {

            //obj MUST be initialized
            //changes made in func (obj pointing to some other block) is reflected in calling code o            obj = new Class1();
            obj = new Class1();
            obj.i = 200;
        }
        static void DoSomething5(in Class1 obj)//obj = o
        {
            //obj CANNOT be initialized
            //obj = new Class1();

            //changes made in func (changing value of properties) is reflected in calling code o
            obj.i = 200;
        }
    }
    public class Class1
    {
        public int i;
    }
}