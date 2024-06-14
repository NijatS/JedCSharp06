using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class MailService : IMailService
	{
		public void ReceiveMessage(string message)
		{
			Console.WriteLine($"Receive {message}");
		}

		public void SendMessage(string message)
		{
			Console.WriteLine($"Send {message}");
		}
	}
}
