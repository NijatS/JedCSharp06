using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal class GmailService : IMailService,IGmailService
	{
		public void ConnectMeet()
		{
            Console.WriteLine("Meet");
        }

		public void ReceiveMessage(string message)
		{
            Console.WriteLine(message);
        }

		public void SendMessage(string message)
		{
            Console.WriteLine(message);
        }
	}
}
