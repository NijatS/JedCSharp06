using Microsoft.VisualBasic;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nijat\OneDrive\Desktop\test.doc";

            string txtPath = @"C:\Users\Nijat\OneDrive\Desktop\C#06\Files\Files\test.txt";
            string txtPath1 = @"C:\Users\Nijat\OneDrive\Desktop\C#06\Files\Files\test1.txt";


            //FileStream stream =  File.Open(path, FileMode.OpenOrCreate);
            //stream.Close();
            // File.Open(path, FileMode.OpenOrCreate);


            //File.Open(@"C:\Users\Nijat\OneDrive\Desktop\C#06\Files\Files\test1.txt", FileMode.OpenOrCreate, FileAccess.Read);


            //StreamWriter writer =  File.AppendText(path);

            // writer.Write("Azima");
            // writer.Close();


            List<string> list = new List<string>() { "Nijat", "Azima", "Yusif" };


            //File.AppendAllLines(path, list);


            //File.AppendAllText(path, "Append-Salam,bugun necesen?");
            //File.AppendAllText(path, "Append-Salam,bugun necesen?");

            //File.WriteAllText(path, "Write-Salam,bugun necesen?");

            //File.WriteAllLines(path, list);


            //string[] data = File.ReadAllLines(path);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //string txt = File.ReadAllText(txtPath);

            //Console.WriteLine(txt);

            //FileStream stream =  File.Create(path);
            // stream.Close();


            //File.Delete(path);

            // File.Copy(txtPath, txtPath1);


            //string testPath= Path.Combine("Nijat", "Test", "test.txt");
            // Console.WriteLine(testPath);
            // C: \Users\Nijat\OneDrive\Desktop\test.doc

            string testPath = Path.Combine("C" + Path.VolumeSeparatorChar, "Users", "Nijat", "OneDrive", "Desktop", "test.doc");

            //Console.WriteLine(testPath);

            //string directory = Path.GetDirectoryName(testPath);


            //Console.WriteLine(directory);

            //Console.WriteLine(Path.GetExtension(testPath));
            //Console.WriteLine(Path.GetFileName(testPath));


            //File.Open(txtPath1, FileMode.Truncate);

            //using (StreamWriter stream1 = File.AppendText(path))
            //{
            //    stream1.Write("test");
            //}

            //File.Open(path, FileMode.Open);



            //*Task: Read the contents of a text file and display it on the console.


            //Console.WriteLine(File.ReadAllText(txtPath));

            //* Task: Append text to an existing file.

            //if (File.Exists(txtPath))
            //{
            //    File.AppendAllText(txtPath, "Test test test");
            //}


            string[] lines = File.ReadAllLines(txtPath);

            List<string> linesList = new List<string>();

            foreach (string line in lines)
            {
                if(!String.IsNullOrEmpty(line))
                    linesList.Add(line);
            }

            File.WriteAllLines(txtPath, linesList);


            Console.WriteLine(File.ReadAllText(txtPath));

            //*Task: Copy a file to a new location with an option to overwrite if the file already exists.


            File.Copy(txtPath, txtPath1, true);



            //* Task: Read all lines from a text file into a list and display them.







        }

    }
}
