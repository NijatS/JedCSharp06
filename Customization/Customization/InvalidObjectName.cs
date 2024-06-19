using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Customization
{
	public class InvalidObjectName : Exception
	{
		static string _systemDefaultMessage = "First letter must be upper case";
		public InvalidObjectName():base(_systemDefaultMessage)
		{
		}

		public InvalidObjectName(string? message) : base(message)
		{
		}

	}
}
