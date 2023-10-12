using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FizzBuzz
    {
        public static IList<string> Execute(int n)
        {
            string[] output = new string[n];
            for (int i = 1; i <= n; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                output[i - 1] = fizz && buzz ? "FizzBuzz" : fizz ? "Fizz" : buzz ? "Buzz" : i.ToString();
            }

            return output;
        }
    }
}
