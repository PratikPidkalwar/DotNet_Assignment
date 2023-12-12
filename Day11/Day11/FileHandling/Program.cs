namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToTextFileFormatted();
            ReadFromTextFileFormatted();
        }
        private static void WriteToTextFileFormatted()
        {
            StreamWriter writer = File.CreateText("c:\\a.txt");
            writer.WriteLine("line 1");
            writer.WriteLine("Line 2");
            writer.WriteLine("line 3");

            writer.Close();
        }
        private static void ReadFromTextFileFormatted()
        {
            string s;
            StreamReader reader = File.OpenText("c:\\a.txt");
            while((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
        }
    }
}