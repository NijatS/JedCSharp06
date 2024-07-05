using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public static class StringExtension
    {
        public static string ToUpperCase(this string text)
        {
            return text.ToUpper();
        }
        public static string ToLowerCase(this string text) {
            return text.ToLower();
        }
    }
}
