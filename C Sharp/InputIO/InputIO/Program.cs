
namespace InputIO
{
    class Program
    {
        public void ReadFile()
        {
            string input = @"F:\BridgeLabz\C Sharp\InputIO\TextFile1.txt";
            StreamReader sr = new StreamReader(input);
            using (StreamReader obj = File.OpenText(input))
            {
                string s = string.Empty;
                while ((s = obj.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                obj.Close();
            }
        }
        public void FileExist()
        {
            string path = @"F:\BridgeLabz\C Sharp\InputIO\TextFile1.txt";
            if (File.Exists(path))
                Console.WriteLine("File exist");
            else Console.WriteLine("File des not exist");
        }
        public void CopyFile()
        {
            string path = @"F:\BridgeLabz\C Sharp\InputIO\TextFile1.txt";
            string destination = @"F:\BridgeLabz\C Sharp\InputIO\TextFileCopy.txt";
            File.Copy(path, destination);
        }
        public void DeleteFile()
        {
            string path = @"F:\BridgeLabz\C Sharp\InputIO\TextFileCopy.txt";
            File.Delete(path);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FileExist();
            program.ReadFile();
            program.CopyFile();
            // program.DeleteFile();

        }
    }
}