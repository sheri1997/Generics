using System;

namespace Generics
{
    class Program
    {
        public static string maximumNumber(string String1, string String2, string String3)//string method which will return a string value
        {
            if (String1.CompareTo(String2) > 0 && String1.CompareTo(String3) > 0 || String1.CompareTo(String2) >= 0 && String1.CompareTo(String3) > 0 || String1.CompareTo(String2) > 0 && String1.CompareTo(String3) >= 0)//if the value of the comparision between the instances created of string 1 and string 2 and string 1 and string 3 will be greater to or equal to 0.
            {
                return String1;
            }
            if (String2.CompareTo(String1) > 0 && String2.CompareTo(String3) > 0 || String2.CompareTo(String1) >= 0 && String2.CompareTo(String3) > 0 || String2.CompareTo(String1) > 0 && String2.CompareTo(String3) >= 0)//if the value of the comparision between the instances created of string 2 and string 1 and string 2 and string 3 will be greater to or equal to 0.
            {
                return String2;
            }
            if (String3.CompareTo(String1) > 0 && String3.CompareTo(String2) > 0 || String3.CompareTo(String1) >= 0 && String3.CompareTo(String2) > 0 || String3.CompareTo(String1) > 0 && String3.CompareTo(String2) >= 0)//if the value of the comparision between the instances created of string 3 and string 1 and string 3 and string 2 will be greater to or equal to 0.
            {
                return String3;
            }
            return String1;//will return any string.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number = " + maximumNumber("C","B" ,"A"));//Maximum String ASCII is at the First Position.
        }
    }
}
