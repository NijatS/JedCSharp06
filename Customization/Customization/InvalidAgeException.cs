using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization
{
	public class InvalidAgeException : Exception
	{
		static string _message = "Siz 120 ilden cox yasiya bilmersiniz.";
		public InvalidAgeException():base(_message)
		{
		}

		public InvalidAgeException(string? message) : base(message)
		{
		}
	}
}
