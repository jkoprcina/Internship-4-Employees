using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_4_Employees.Interface.Extensions
{
    public static class InputCheckers
    {
        public static bool CheckIfNumber(this string inputString) => inputString.All(char.IsDigit);

        public static bool CheckIfEmpty(this string inputString) => inputString == "";
    }
}
