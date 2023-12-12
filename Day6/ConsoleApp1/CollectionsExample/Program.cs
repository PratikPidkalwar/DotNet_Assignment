using System.Collections;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList objArrayList= new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("Pra");
            objArrayList.Add(2.23);
            objArrayList.Add(true);

          // Console.WriteLine(objArrayList.Count);
            Console.WriteLine();

            ArrayList objArrayList2 = new ArrayList();
            objArrayList2.Add(100);

            objArrayList.AddRange(objArrayList2);


            objArrayList.Insert(0, "new");
            objArrayList.InsertRange(0, objArrayList2);

            Console.WriteLine();



            //objArrayList.Remove(10);
            //objArrayList.RemoveAt(1);
            objArrayList.RemoveRange(0, 1);

            Console.WriteLine(objArrayList.Count);

            foreach (object  i in objArrayList)
            {
                Console.WriteLine(i);
            }

        }
    }
}