using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyClasses
{
    public class People
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class RandomDataSimulation
    {
        private static Random Random = new Random();

        private static string[] FirstNames = { "Azima", "Nijat", "Yusif" };

        public List<People> DataSimulation(int numberOfEntries)
        {
            var people = new List<People>();
            for (int i = 0; i < numberOfEntries; i++)
            {
                var name = $"{FirstNames[Random.Next(FirstNames.Length)]}";
                var age = Random.Next(1, 100);
                var dateOfBirth = DateTime.Now.AddYears(-age).AddDays(Random.Next(1,100));
                var ID = Guid.NewGuid();

                people.Add(new People()
                {
                    Name = name,
                    Age = age,
                    DateOfBirth = dateOfBirth,
                    Id = ID
                }); 
            }
            return people;
        }

    }
    public static class MathOperation
    {
        public static long Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Sorry,but number can not be negative:");
            if (number == 0)
                return 1;

            long answer = 1;
            for (int i = 2; i <= number; i++)
            {
                answer *= i;
            }
            return answer;
        }
        public static double Power(double baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        public static int GCD(int num1, int num2)
        {
            if (num1 < 0)
                num1 = -num1;
            if (num2 < 0)
                num2 = -num2;

            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }
    }
}
