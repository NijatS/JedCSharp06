using Library1;
using Library2;
using Library3;
using Library4;
using System.ComponentModel;
using System.Reflection;

namespace Reflections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string text = "Salam,bugun necesen?";
            //Console.WriteLine(text.ToUpperCase());
            //Console.WriteLine(text.ToLowerCase());


            //Library4Demo.Walk();

            //var assembly = Assembly.GetExecutingAssembly();
            //var assembly1 = Assembly.GetAssembly(typeof(Library1Demo));
            //var assembly2 = Assembly.GetAssembly(typeof(Library2Demo));
            //var assembly3 = Assembly.GetAssembly(typeof(Library3Demo));
            //var assembly4 = Assembly.GetAssembly(typeof(Library4Demo));

            //Console.WriteLine(assembly.Location);
            //Console.WriteLine(assembly1.Location);
            //Console.WriteLine(assembly2.Location);
            //Console.WriteLine(assembly3.Location);

            //Console.WriteLine(assembly4.Location);

           //int result =  GenericParse<int>("5");
           // Console.WriteLine(result.GetType().Name);


            Library1Demo demo = new Library1Demo();
            var type = demo.GetType();

            //var methods = type.GetMethods();

            //foreach (var method in methods)
            //{
            //    if(method.GetParameters().Length == 0)
            //        method.Invoke(demo, null);
            //}

            //var parametrs = new object[] { "sasa" };
            //try
            //{
            //    var method = type.GetMethod("Walk1WithP");
            //    method.Invoke(demo, new object[] { "Salam","Necesen" });
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //var assembly =  Assembly.LoadFrom("Library1.dll");
            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item);

            //}
            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item);
            }



        }
        static T GenericParse<T>(string data)
        {
            var convertor = TypeDescriptor.GetConverter(typeof(T));
            T? parsedData = (T?)convertor.ConvertFromString(data);
            if (parsedData is null)
                throw new Exception("Error handling in parsing operation");

            return parsedData;
        }

    }
}
