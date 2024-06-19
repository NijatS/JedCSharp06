using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Extensions
{
	public static class ArrayExtensions
	{
		public static int SumEvenNumbers(this int[] numbers)
		{
			int sum = 0;
			foreach (var num in numbers)
			{
				if (num % 2 == 0)
					sum += num;
			}
			return sum;
		}
	}
}
