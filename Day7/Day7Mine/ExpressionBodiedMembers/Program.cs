using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ExpressionBodiedMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1("Pratik");
            c1.Display();

         
            Console.WriteLine(c1.Add(12, 12));
        }
    }
    public class Class1
    {
        //Methods
        public void Display() => Console.WriteLine("Display ExpressionBodiedMember");
        public int Add(int a, int b) => a + b;

        //property

        private string name;

        public string Name
        {
            get => name; set => name = value;
        }

        //read only property

        private string prop1;
        public string Prop1 => prop1;

        //Constructor
        //only single statement is allowed - so ideal for constructor with one parameter

        public Class1 (string name) =>this.name = name;


    }
}