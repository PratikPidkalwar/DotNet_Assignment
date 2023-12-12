
namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
             

            IdbFunction i;
            i = o;
            i.Insert();

        }
    }
    public interface IdbFunction
    {
        void Insert();
        void Update();
        void Delete();
        void show();
    }
    public class Class1 : IdbFunction
    {
        public void show()
        {
            Console.WriteLine("SHOW");
        }

        void IdbFunction.Delete()
        {
            Console.WriteLine("delete from Class1");
        }

        void IdbFunction.Insert()
        {
            Console.WriteLine("insert from Class1");
        }

        void IdbFunction.Update()
        {
            Console.WriteLine("update from Class1");
        }
        
    }
}