using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public static class HelperOperations
    {
        public static string RemoveAllCharsExceptLetters(this string name)
        {
            if (string.IsNullOrEmpty(name)) return "";
            return Regex.Replace(name, "[^a-zA-Z]", "");
        }

        public static bool StringIsEqualTo(this string str1, string str2)
        {
            return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        }
    }
}