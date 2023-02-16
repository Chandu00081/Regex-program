﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexp
{
    internal class UserValidation
    {
        public const string FIRST_NAME_REGEX = "^[A-Z][a-zA-Z]{2}$";
        public void ValidationFirstName(string fname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(fname);
            Console.WriteLine(result);
        }

        public string LASTNAME_REGEX = "^[A-Z][a-zA-Z]{2}$";
        public void ValidationLastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
    } 
}
