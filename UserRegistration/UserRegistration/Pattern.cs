using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Pattern
    {
        public static string RegexRules = "^[A-Z][a-z]{3,}$";
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if (Regex.IsMatch(FName, RegexRules))
            {
                Console.WriteLine("First Name: " + FName);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
  

