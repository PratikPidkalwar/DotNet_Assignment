namespace EventHandling
{
    internal class Program
    {
        //static void Main()
        //{
        //    Class1 objClass1 = new Class1();
        //    //add an event handler

        //    //if the InvalidP1 event happens for objClass1,
        //    //then call the event handling function(objClass1_InvalidP1())
        //    objClass1.InvalidP1 += objClass1_InvalidP1;

        //    objClass1.P1 = 20;

        //}

        //static void objClass1_InvalidP1()
        //{
        //    Console.WriteLine("Invalid P1 Event called");

        //}
        static void Main()
        {
           Class1 objClass1= new Class1();
            objClass1.Invalid_p1 += ObjClass1_Invalid_p1;

            objClass1.P1 = 20;
            Console.WriteLine(objClass1.P1);
        }

        private static void ObjClass1_Invalid_p1()
        {
            Console.WriteLine("Invalid P1 Event called");
        }

        //Developer
        //Step 1: Create a delegate class having the same signature as the event

        public delegate void Invalid_p1_EventHandler();
        public class Class1
        {
            //step2: declare the event of the delegate type
            //event is a referance of the delegate type
            public event Invalid_p1_EventHandler Invalid_p1;
            private int p1;
            public int P1
            {
                get { return p1; }
                set
                {
                    if (value > 100)
                    {
                        p1 = value;
                    }
                    else
                    {
                        //step3:raise the event
                        Invalid_p1();
                    }
                }
            }
        }

      
    }

}