//using static DefaultImplementationInterfaces.IdbFunctions;

namespace DefaultImplementationInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Class1 o = new Class1();
            o.Insert();
            o.Select();
            

            (o as IdbFunctions).Insert();
            (o as IdbFunctions).Select();

        }
    }
    public interface IdbFunctions
    {
        void Insert();
        void Update();

        //default implementation code by programmer
        void Select()
        {
            Console.WriteLine("Default implementation of select");
        }
    }
    public class Class1 : IdbFunctions
    {

        public void Insert()
        {
            Console.WriteLine("In class Insert");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }

        public void Select()
        {
            Console.WriteLine("Class implicit implementation");
        }

        void IdbFunctions.Select()
        {
            Console.WriteLine("Class explicit implementation");
        }

    }
}