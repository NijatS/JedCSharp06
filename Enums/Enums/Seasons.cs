using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
	public enum Seasons
	{
		Winter=1,
		Spring,
		Summer,
		Fall


	}
	public class EnumOperations
	{
		public string ReturnValue(int seasonName)
		 => Enum.GetName(typeof(Seasons), seasonName);
	}
	
}
