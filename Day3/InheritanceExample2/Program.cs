namespace InheritanceExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
          // BaseClass o = new BaseClass();
          TestAccessSpecifier.BaseClass o2=new TestAccessSpecifier.BaseClass();
            
        }
    }

    public class BaseClass
    {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
            private protected int PRIVATE_PROTECTED; 
    }

    public class DerivedClass : TestAccessSpecifier.BaseClass
    {
        void DoNothing()
        {

        }
    }
}