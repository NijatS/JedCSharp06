using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal interface IMailService
	{
		public void SendMessage(string message);
		public void ReceiveMessage(string message);
	}
}
