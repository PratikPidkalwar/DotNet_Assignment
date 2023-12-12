namespace ImplicitVariable
{
    internal class Program
    {
        static void Main1()
        {
            int i = 10;
            var j = 20;  //implicit variable
                         //used only for local variable
                         // cant be use for class level vars,fn params and return types

            j = 200;
            //j="aa" //error

            //var k="qqq";
            //k=1234;

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}


namespace AnonymousMethods

{
    internal class Program
    {
        static void Main()
        {
            //Class1 o = new Class1 { a = 10, b = "partik", char = true };
           // var o2=new { a = 10, b = "partik", c = true };

            var o=new {Id=1,Name="Name",Salary=1.2,IsRestricted=false};
            var o2 = new { Id = 1, Name = "Name", Salary = 1.2 };
            Console.WriteLine(o.Id);
            Console.WriteLine(o.GetType());
            Console.WriteLine(o2.GetType());
        }
    }

}