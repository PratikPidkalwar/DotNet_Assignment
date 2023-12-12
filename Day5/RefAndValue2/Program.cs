namespace RefAndValue2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int i=10, j=20;
            int i, j;
            Init(out i, out j);
            Swap(ref i, ref j);
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            Print( i,  j);
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //out is similar to ref-changes made in func reflect back in calling code 
        //the initial value is discarded
        //out variables MUST be initialized in the function 
        static void Init(out int x, out int y) {
            x = 100;
            y = 200;
        }
        static void Print(in int x, in int y)
        {
            //x = 1000;
            //y=2000;//error
            //Console.WriteLine(x,y);
        }

    }
}