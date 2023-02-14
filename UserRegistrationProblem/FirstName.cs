using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class FirstName
    {
        public static void FirstN()
        {
            string pattern = "^[A-Z]{1}[A-Za-z]{2}$";
            string[] input = { "Aaa", "Vir", "11", "vbp", "ohk" };
            foreach(var data in input)
            {
                Regex regexobj= new Regex(pattern);
                if(regexobj.IsMatch(data))
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
