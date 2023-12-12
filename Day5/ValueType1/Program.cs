namespace ValueType1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Hello, World!");
          MyPoint p= new MyPoint();
            Console.WriteLine(p.x);
        }
    }
    public struct MyPoint
    {
        public int A { get; set;}
        public int x;
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public MyPoint()
        {
            //this.X = 10;
            //this.A = 30;
            //this.b = 0;
            //this.B = 40;
        }
    }
}