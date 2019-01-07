using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Internship_4_Employees.Interface.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string text)
        {
            text = text.Trim();
            return Regex.Replace(text, @"\s{2,}", " ");
        }

        public static string CapitalizeWords(this string text)
        {
            return Regex.Replace(text.ToLower(), @"(^\w)|(\s\w)", m => m.Value.ToUpper());
        }

        public static string RemoveAllTheWhiteSpaces(this string text)
        {
            return Regex.Replace(text, @"\s+", "");
        }
    }
}
