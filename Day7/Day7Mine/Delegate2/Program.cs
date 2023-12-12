namespace Delegate2
{
    public delegate int MathDel(int a, int b);//Delegate class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine(MathOperation(Add,12,12));
            Console.WriteLine(MathOperation(Sub,20,10));
            Console.WriteLine(MathOperation(Mul,10,10));
        }
        //function to call is being passed as a parameter
        //enables late binding
        static int MathOperation (MathDel OMath, int a, int b)
        {
            return OMath(a, b);
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Sub(int a,int b)
        {
            return a - b;
        }
        static int Mul(int a,int b)
        {
            return a * b;
        }
    }
}