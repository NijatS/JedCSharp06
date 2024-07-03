using FileInfo;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace FileInfoTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////File.Create(path);

            //string news = "Media ekspertinin vəkili Aqil Layıc təqdimata etiraz edib, müvəkkilinin sərbəst buraxılmasını xahiş edib.\r\nXətai Rayon Məhkəməsi prokurorun təqdimatını əsaslı hesab edib.";

            //Console.WriteLine(news.Length);

            //File.AppendAllText(path, news);

            //FileInfo fi = new FileInfo(path);

            //Console.WriteLine(fi);

            //List<string> fileNames =  Directory.EnumerateDirectories(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU").ToList();


            // foreach (string file in fileNames)
            // {
            //     Console.WriteLine(file);

            //}

            //  Console.WriteLine(Directory.Exists());
            //string parent = Directory.GetParent(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU").FullName;

            //Console.WriteLine(Directory.GetCurrentDirectory());

            //string root = Directory.GetDirectoryRoot(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU");
            //Console.WriteLine(root);


            //foreach (var item in Directory.EnumerateDirectories(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU"))
            //{
            //    Console.WriteLine(item);
            //}


            //Directory.SetCreationTime(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU", DateTime.Now.AddYears(-2).AddMonths(-9));


            //Console.WriteLine(Directory.GetCreationTime(@"C:\Users\Nijat\OneDrive\Desktop\ASOIU"));


            //Console.WriteLine(Directory.GetCreationTime(@"C:\Users\Nijat\OneDrive\Desktop\Videos"));

            //Directory.SetCreationTime(@"C:\Users\Nijat\OneDrive\Desktop\Videos", DateTime.Now);


            //Console.WriteLine(Directory.GetCreationTime(@"C:\Users\Nijat\OneDrive\Desktop\Videos"));


            //foreach (var item in Directory.GetLogicalDrives())
            //{
            //    Console.WriteLine(item);
            //}


            //Directory.Move(@"C:\Users\Nijat\OneDrive\Desktop\Samir", @"C:\Users\Nijat\OneDrive\Desktop\Samir2");


            //Console.WriteLine(parent);
            string path = @"C:\Users\Nijat\OneDrive\Desktop\C#06\FileInfo\FileInfo\test2.json";


            Person person = new Person()
            {
                Id = 1,
                Name = "Azima",
                Surname = "Qadirli"
            };
            Stream st = File.Open(path, FileMode.OpenOrCreate);



            //XmlSerializer serializer = new XmlSerializer(typeof(Person));

            ////serializer.Serialize(st, person);

            //Person obj = (Person)serializer.Deserialize(st);

            //Console.WriteLine(obj.Name);

            //st.Close();

            //JsonSerializer.Serialize(st, person);

            //Person obj = JsonSerializer.Deserialize<Person>(st);

            //Console.WriteLine(obj.Name);
            //st.Close(); 

            //string json =  JsonConvert.SerializeObject(person);
            //Console.WriteLine(json);



            //#pragma warning disable SYSLIB0011

            //            BinaryFormatter fm = new BinaryFormatter();

            //            fm.Serialize(st, person);

            //            st.Close();

            //             st = File.Open(path, FileMode.Open);


            //            var obj =  (Person)fm.Deserialize(st);
            //            Console.WriteLine(obj.Name);
            //            st.Close();

            //#pragma warning restore SYSLIB0011

            //*Task: Serialize a list of objects to a JSON file and deserialize it back to a list.

            Person person1 = new Person()
            {
                Id = 2,
                Name = "Yusif",
                Surname = "Pirquliyev"
            };
            Stream stream = File.Open(@"C:\Users\Nijat\OneDrive\Desktop\C#06\FileInfo\FileInfo\yusif.json", FileMode.OpenOrCreate);

            //System.Text.Json.JsonSerializer.Serialize(stream, person1);
          Person obj=  System.Text.Json.JsonSerializer.Deserialize<Person>(stream);
            Console.WriteLine(obj.Name);

            stream.Close();

        }
    }
}
