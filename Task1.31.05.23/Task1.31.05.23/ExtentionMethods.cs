using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._31._05._23
{
    public static class ExtensionMethods
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsContainsDigit(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public static string ToCapitalize(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1);
        }

    }

}