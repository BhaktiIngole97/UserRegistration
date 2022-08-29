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
        public static string EmailRule = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public void validateFName(string FName)
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
        public void validateEmail(string Email)
        {
            if (Regex.IsMatch(Email, EmailRule))
            {
                Console.WriteLine("Email ID: " + Email);
            }
            else
            {
                Console.WriteLine("Invalid Email ID");
            }
        }
    }
}

