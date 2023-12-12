using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c =new Class1();
            // c.Display();

            //positional parameters
            //Console.WriteLine(o.Add(10, 20, 30));

            Console.WriteLine(c.Display(10,10));
            Console.WriteLine(c.Display1(num1:10));
            //Console.WriteLine(o.Add(10, a: 30)); --error
            // c.Display("Pratik");

            Class2 c2 = new Class2();
            c2.Dosomething();
            //new Class2() is an object of Class2
            //c2 is refering to(pointing to) the object created
        }

    }
    public class Class1 // :Object
    {
        /*  public void Display()
          {
              Console.WriteLine("Display");
          }

        //overload a function - same function name, diff parameters
          public void Display(string str )
          {
              Console.WriteLine("string is: "+str);
          }*/
        public int Display(int num1,int num2=0)
        {
            return num1 + num2;
        }
        public int Display1(int num1, int num2 = 0,int num3=0)
        {
            return num1 + num2+ num3;
        }
        //error - default values are given from right to left
        //public int Add3(int a=0, int b, int c )
        //{
        //    return a + b + c;
        //}
    }
    public class Class2
    {
       
        public void Dosomething()
        {
            int i = 100;
            Console.WriteLine(i);

            //local function
            //local function can access local variables defined in the outer function
            //local function -cannot have an access specifier
            //implicitly private 
            //only available in outer function
            void Dosomething2()
            {
                Console.WriteLine("Dosomething2");
                i++;
                Console.WriteLine(i);
            }
            Dosomething2();
            Console.WriteLine(i);

        }

    }

}