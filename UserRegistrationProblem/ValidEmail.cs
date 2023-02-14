using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class ValidEmail
    {
        public static void ValidEmailId()
        {
            string pattern = "^([a-zA-Z0-9_]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)$";
            string[] input = { "virtapatil58827@gmail.com", "", "11", "vbp", "ohk" };
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