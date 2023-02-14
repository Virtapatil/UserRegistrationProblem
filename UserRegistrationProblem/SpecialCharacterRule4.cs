using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class SpecialCharacterRule4
    {
        public static void SpecialChar4()
        {
            string pattern = "^[A-Z_@-]{1}[0-9]{3}[a-z]{8}$";
            string[] input = { "v-555irtabpl", "V@123irtabpal", "a1bc234defgh", "abcdefghi" };
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
