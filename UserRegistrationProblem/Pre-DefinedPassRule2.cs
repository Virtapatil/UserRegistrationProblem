using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Pre_DefinedPassRule2
    {
        public static void PreDefPassRule2()
        {
            string pattern = "^[A-Z]{1}[a-z]{8}$";
            string[] input = { "Virtabpal", "virtaBpal", "abcdefgh", "Abcdefghi" };
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
