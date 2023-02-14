using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class PreDefinedMobileFormat
    {
        public static void PreDefMobile()
        {
            string pattern = "^[0-9]{2}[ ]?[0-9]{10}$";
            string[] input = { "913 7709523216", "91 77778898673", "8208045041", "919921020082", "91 7709503216" };
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
