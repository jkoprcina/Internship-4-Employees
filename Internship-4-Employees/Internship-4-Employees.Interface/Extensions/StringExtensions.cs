using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Interface.Extensions
{
    public static class StringExtensions
    {
        public static string CheckingNamesAndLastnames(this string text)
        {
            text = text.Trim();
            return text;
        }
    }
}
