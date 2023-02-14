using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class NumericNumRule3
    {
        public static void NumericRule3()
        {
            string pattern = "^[A-Z]{1}[0-9]{3}[a-z]{8}$";
            string[] input = { "v555irtabpl", "V123irtabpal", "a1bc234defgh", "abcdefghi" };
            foreach (var data in input)
            {
                Regex regexobj = new Regex(pattern);
                if (regexobj.IsMatch(data))
                {
                    Console.WriteLine("{0} is Valid", data);
                }
                else
                {
                    Console.WriteLine("{0} is Invalid", data);
                }
            }
        }
    }
}
