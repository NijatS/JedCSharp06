using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization.Extensions
{
	public static class Extensions
	{
		public static bool isEven(this int number)
		{
			//return number % 2 == 0;

			//if(number % 2 == 0)	
			//	return true;
			//return false;

			return number % 2 == 0 ? true : false;

		}
		
		public static string Reverse(this string s)
		{
			char[] reversed = s.ToCharArray();
			Array.Reverse(reversed);
			return String.Join("",reversed);
		}

		public static bool IsWeekend(this DateTime dt)
		{
			if(dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
				return true;
			return false;

		}

		public static int Factorial(this int num)
		{
			if (num < 0)
				throw new InvalidMathOperationException("Factorial of negative numbers is not defined.");

			int fac = 1;
			for (int i = 1; i <= num; i++)
				fac *= i;

			return fac;
		}
	}
}
