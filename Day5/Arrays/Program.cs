namespace Arrays
{
    internal class Program
    {
        static void Main1(string[] args)
        {
           int[] arr=new int[5];

            for(int i=0; i<arr.Length; i++)
            {

                //arr[i]=int.Parse(Console.ReadLine()!);
                //arr[i]=int.Parse(Console.ReadLine());

                //Console.Write("Enter the value of arr[0]: ");

                //String concate
                // Console.Write("Enter the value of arr["+i.ToString()+"]:  ");

                //PlaceHolder
                // Console.Write("Enter the value of arr[{0}]: ",i);

                //string Interpolation
                //Being with $ 
                Console.Write($"Enter the value of arr[{i}]: ");



                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for(int i=0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            foreach(int i in arr)  //readonly
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args) {
            int[] arr = { 20, 30, 40, 50, 60,10 };
            int[] arr2 =new int[] { 1, 2, 3 };
            int[] arr1 = { 2, 5, 3, 1, 9, 0 };

            int pos = Array.IndexOf(arr, 30);
            // int pos1 = Array.LastIndexOf(arr,10);
            int pos1 = Array.BinarySearch(arr, 10);
            // Console.WriteLine(pos1);

           // int[]arr3= { };
            //Array.Copy(arr, arr2, arr.Length);
            //Array.Clear(arr);
            //Console.WriteLine(arr);
            // Console.WriteLine(arr3);

           
            Array.Reverse(arr1);
            Array.Sort(arr1);
            for(int i = 0;i<arr1.Length;i++)
                Console.Write(arr1[i]+" ");

            //Array.ConstrainedCopy
        }
    }
}