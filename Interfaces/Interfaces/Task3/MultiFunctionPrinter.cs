using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task3
{
	internal class MultiFunctionPrinter : IPrintable, IScannable
	{
		public void Print()
		{
            //throw new NotImplementedException();
            Console.WriteLine("Print");
        }

		public void Scan()
		{
            //throw new NotImplementedException();
            Console.WriteLine("Scan");
        }
	}
}
