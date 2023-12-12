namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // CreateDirectory();
           // CreateFile();
           // AddText();
           // CheckDrive();
        }
        static void CreateDirectory()
        {

            //Directory.CreateDirectory("C:\\new");
            Directory.CreateDirectory(@"D:\Directory");


            //DirectoryInfo dir = new DirectoryInfo("C:\\aaaa");

            //dir.
     

        }

        static void CreateFile()
        {

            File.Create("D:\\Directory\\a.txt");
            //File.

            //FileInfo file = new FileInfo("C:\\aaaa\\a.txt");
            //file.
            //StreamWriter writer = File.CreateText("c:\\aaaa\a.txt");
            //writer.WriteLine("line 1");
            //writer.WriteLine("Line 2");
            //writer.WriteLine("line 3");

           // writer.Close();
        }
        static void AddText()
        {
            StreamWriter writer = File.CreateText("D:\\Directory\\ab.txt");
            writer.WriteLine("line 1");
            writer.WriteLine("Line 2");
            writer.WriteLine("line 3");

            writer.Close();
        }
         static void CheckDrive()
        {

            DriveInfo drive = new DriveInfo("D");
            //drive.
            // if(drive.DriveType == DriveType.

        }
    }
}