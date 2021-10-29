using System;

namespace Generics
{
    class Program
    {
        public static T maximumNumber<T>(T Value1, T Value2, T Value3) where T: IComparable//Generic Mathod T, IComparable is used as a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0 || Value1.CompareTo(Value2) >= 0 && Value1.CompareTo(Value3) > 0 || Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) >= 0)//if the value of the comparision between the instances created of Value 1 and Value 2 and Value 1 and Value 3 will be greater to or equal to 0.
            {
                return Value1;
            }
            if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0 || Value2.CompareTo(Value1) >= 0 && Value2.CompareTo(Value3) > 0 || Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) >= 0)//if the value of the comparision between the instances created of Value 2 and Value 1 and Value 2 and Value 3 will be greater to or equal to 0.
            {
                return Value2;
            }
            if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0 || Value3.CompareTo(Value1) >= 0 && Value3.CompareTo(Value2) > 0 || Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) >= 0)//if the value of the comparision between the instances created of Value 3 and Value 1 and Value 3 and Value 2 will be greater to or equal to 0.
            {
                return Value3;
            }
            return default;//will return a default value because it is generic and it can return any data type.
        }
        static void Main(string[] args)//main method
        {
            Console.WriteLine("Maximum Number = " + Program.maximumNumber<int>(10, 8, 4));//Object created for a integer data type.
            Console.WriteLine("Maximum Number = " + Program.maximumNumber<double>(10.8, 5.2, 4.8));//Object created for a double data type.
            Console.WriteLine("Maximum Number = " + Program.maximumNumber<string>("C", "B", "A"));//Object created for a string data type.
        }
    }
}
