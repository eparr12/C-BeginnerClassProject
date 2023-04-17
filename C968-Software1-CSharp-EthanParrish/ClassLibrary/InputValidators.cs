using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C968_Software1_CSharp_EthanParrish.ClassLibrary
{
    public static class InputValidators
    {
        static readonly string letters = "^[A-Za-z ]*$";
        static readonly string numbers = "^[0-9]*$";

        public static bool textboxValidator(string text)
        {
            if ((string.IsNullOrWhiteSpace(text)) || (!Regex.Match(text, letters).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool numberValidator(string number)
        {
            string nmbr = number.ToString().Replace(".", string.Empty);

            if ((string.IsNullOrWhiteSpace(nmbr)) || (!Regex.Match(nmbr, numbers).Success))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool minMaxValidator(string min, string max, string inv)
        {
            var Min = int.Parse(min);
            var Max = int.Parse(max);
            var Inv = int.Parse(inv);

            return ((Min < Max) && (Min <= Inv) && (Inv <= Max));
        }
    }
}
