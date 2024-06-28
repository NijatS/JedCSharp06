using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyClasses
{
    public static class PasswordGenerator
    {
        private readonly static string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789!@#$%^&*()_=+-_<>?";
        public static string GenerateUniquePassword(int length)
        {
            StringBuilder password = new();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                password.Append(letters[random.Next(letters.Length)]);
            }
            return password.ToString();
        }
    }
}
