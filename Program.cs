using System;

namespace Generics
{
    class Program
    {
        public static int maximumNumber(int Number1, int Number2, int Number3)//integer method which will return an integer value
        {
            if (Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) > 0 || Number1.CompareTo(Number2) >= 0 && Number1.CompareTo(Number3) > 0 || Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) >= 0)//if the value of the comparision between the instances created of Number 1 and Number 2 and Number 1 and Number 3 will be greater to or equal to 0.
            {
                return Number1;
            }
            if (Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) > 0 || Number2.CompareTo(Number1) >= 0 && Number2.CompareTo(Number3) > 0 || Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) >= 0)//if the value of the comparision between the instances created of Number 2 and Number 1 and Number 2 and Number 3 will be greater to or equal to 0.
            {
                return Number2;
            }
            if (Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) > 0 || Number3.CompareTo(Number1) >= 0 && Number3.CompareTo(Number2) > 0 || Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) >= 0)//if the value of the comparision between the instances created of Number 3 and Number 1 and Number 3 and Number 2 will be greater to or equal to 0.
            {
                return Number3;
            }
            return Number1;//will return any value.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number = " + maximumNumber(10, 20, 30));//Maximum Number is at the Third Position.
        }
    }
}
