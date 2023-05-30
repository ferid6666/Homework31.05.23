using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._31._05._23
{
    public class Student
    {
        public string FullName { get; set; }
        public string GroupNum { get; set; }
        public int Age { get; set; }

        public static bool CheckGroupNum(string groupNum)
        {
            if (groupNum.Length == 4 && char.IsUpper(groupNum[0]) && char.IsDigit(groupNum[1]) && char.IsDigit(groupNum[2]) && char.IsDigit(groupNum[3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckFullName(string fullName)
        {
            Console.WriteLine(CheckFullName);
           
            return true;
           
        }
    }
}
