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
        public static string NameRule = "^[A-Z][a-z]{3,}$";
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if (Regex.IsMatch(FName, NameRule))
            {
                Console.WriteLine("First Name: " + FName);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }

        public void validateLName(string LName)
        {
            if (Regex.IsMatch(LName, NameRule))
            {
                Console.WriteLine("Last Name: " + LName);
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
    

  

