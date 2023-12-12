namespace ValueType2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display1(0);
            Display2(TimeOfDay.Afternoon);
            Console.ReadLine();
        }
        static void Display1(int t)
        {
            if (t == 0)
                Console.WriteLine("Good Morning");
            else if (t == 1)
                Console.WriteLine("Good Afternoon");
            else if (t == 2)
                Console.WriteLine("Good Evening");
            else if (t == 3)
                Console.WriteLine("Good Night");
        }
        static void Display2(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning)
                Console.WriteLine("Good Morning");
            else if (t == TimeOfDay.Afternoon)
                Console.WriteLine("Good Afternoon");
            else if (t == TimeOfDay.Evening)
                Console.WriteLine("Good Evening");
            else if (t == TimeOfDay.Night)
                Console.WriteLine("Good Night");
        }
    }


    public enum TimeOfDay //: long
    {
        Morning,
        Afternoon = 30,
        Evening,
        Night
    }
}
