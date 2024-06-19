using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization
{
	public class InvalidMathOperationException : Exception
	{

		public InvalidMathOperationException()
		{
		}

		public InvalidMathOperationException(string? message) : base(message)
		{
		}
	}
}
