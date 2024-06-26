using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Reflection;
using System.Text;

namespace HandyClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random rn1 = new Random(46);
            //Random rn2 = new Random(46);
            //Random rn3 = new Random(46);


            //Console.WriteLine(rn1.Next());
            //Console.WriteLine(rn2.Next());
            //Console.WriteLine(rn3.Next());

            //Console.WriteLine(Math.PI);

            //Console.WriteLine(Math.Ceiling(5.4));
            //Console.WriteLine(Math.Floor(5.4));
            //Console.WriteLine(Math.Round(5.4));

            //Console.WriteLine(Math.Min(5,6));


            //Process.Start("chrome.exe");
            //Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.tutorialsteacher.com");
            //Process.Start(@"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE");


            //foreach(var process in Process.GetProcesses())
            //{
            //    Console.WriteLine(process.Id);
            //}

            //ProcessStartInfo startInfo = new ProcessStartInfo()
            //{
            //    FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe"
            //};

            //var prc = Process.Start(startInfo);
            //for(int i = 0; i < 50000; i++)
            //{
            //    Console.WriteLine();
            //}
            //prc.Kill();


            //ZipFile.CreateFromDirectory(@"C:\Users\Nijat\OneDrive\Desktop\Samir", @"C:\Users\Nijat\OneDrive\Desktop\test2.zip");

            //ZipFile.ExtractToDirectory(@"C:\Users\Nijat\OneDrive\Desktop\test2.zip", @"C:\Users\Nijat\OneDrive\Desktop\Test2");


            //String test = new String("Sas");
            //Console.WriteLine(test);


            //StringBuilder stringBuilder = new StringBuilder("Salam");

            //stringBuilder.Append(",necesen");

            //stringBuilder.Append("?");

            //stringBuilder.Append(string.Format(new CultureInfo("en-US"),"{0:C}",45));


            //stringBuilder.Replace("45", "55");

            //stringBuilder.Insert(0, "necesen,");

            //stringBuilder.Remove(0, 5);


            //Console.WriteLine(stringBuilder);


            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);



            //Guid.TryParse("629d27af-bb8d-406b-a486-d5a8239na2ad", out guid);
            Console.WriteLine(guid);



            //Console.WriteLine(DateTime.Now.AddTicks(4));


            
            Console.WriteLine(DateTime.DaysInMonth(2023, 2));


        }
    }
}
