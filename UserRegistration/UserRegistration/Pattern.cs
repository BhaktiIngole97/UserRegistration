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
        public static string EmailRule = "^[a-zA-Z0-9]+([.-+][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public static string MobileRule = "^[1-9]{2}[ ][0-9]{10}";
        public static string PasswordRule = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*#?&]).{8,}$";
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
        public void validateMobile(string Mobile)
        {
            if (Regex.IsMatch(Mobile, MobileRule))
            {
                Console.WriteLine("Mobile No: " + Mobile);
            }
            else
            {
                Console.WriteLine("Invalid Mobile No.");
            }
        }
        public void validatePassword(string Password)
        {
            if (Regex.IsMatch(Password, PasswordRule))
            {
                Console.WriteLine("Password: " + Password);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
            }
        }
    }
}

