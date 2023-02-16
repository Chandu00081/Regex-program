using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Regex  Statement Using REGEX");
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter The First Name: ");
            string fname = Console.ReadLine();
            userValidation.ValidationFirstName(fname);
        }
    }
}
