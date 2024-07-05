using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Library1Demo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public void Walk1()
        {
            Console.WriteLine("Walk 1 calisdi");
        }
        public void Talk1()
        {
            Console.WriteLine("Talk 1 calisdi");
        }
        public void Walk1WithP(string p,string c)
        {
            Console.WriteLine(p+c+" parametrli calisdi");
        }
    }
}
