using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Pre_DefinedPasswordRule1
    {
        public static void PreDefPassRule1()
        {
            string pattern = "^[a-z]{8}$";
            string[] input = { "virtabpl", "Virtabpl", "abcdefgh", "abcdefghi" };
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
