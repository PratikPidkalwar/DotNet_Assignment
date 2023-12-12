namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 3];



            Console.WriteLine(arr.Rank); //no Diamensions  -2
            Console.WriteLine(arr.Length); //12
            Console.WriteLine(arr.GetLength(0));  //4  -no. of element in 0th dimension
            Console.WriteLine(arr.GetLength(1));   //3 -  --------,,------1st ----------

            Console.WriteLine(arr.GetUpperBound(0));  //3   length -1
            Console.WriteLine(arr.GetUpperBound(1));  //2   Length -1

            for(int i= 0;i < arr.GetLength(0); i++)
            {
                for(int j=0;j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter the value of arr[{i},{j}]: ");

                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}