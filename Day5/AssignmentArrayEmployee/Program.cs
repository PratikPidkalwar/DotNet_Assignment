

//1.CDAC YCP has certain number of batches. each batch has certain number of students
//         accept number of batches. for each batch accept number of students.
//         create an array to store mark for each student (1 student has only 1 subject mark)
//        accept the marks.
//        display the marks.


namespace AssignmentArrayBatches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b, m, s;

            Console.WriteLine("Enter the Batchs: ");
            b =Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[b][];
            
            for(int i=0; i < b; i++)
            {
                Console.WriteLine("Enter the students: ");
                s = Convert.ToInt32(Console.ReadLine());
                arr[i]=new int[s];
                //arr[i] = s;

                for(int j=0; j < s; j++)
                {
                    Console.WriteLine($"Enter marks for student [{i}][{j}]: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = m;     
                }
            }
            Console.WriteLine();

            Console.WriteLine("Marks are: ");
            for (int i=0; i < b; i++)
            {
               
                for (int j=0; j < arr[i].Length; j++)
                {
                    
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }



        }
    }
}