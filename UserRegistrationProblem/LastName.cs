using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class LastName
    {
        public static void LastN()
        {
            string pattern = "^[A-Z]{1}[A-Za-z]{2}$";
            string[] input = { "ohk", "Pat", "11b", "Vbp", "ohk" };
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
