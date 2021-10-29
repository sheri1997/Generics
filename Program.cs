using System;

namespace Generics
{
    public class Program<T>where T: IComparable//Generic Class, IComparable is used as a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
    {
        public T Value1, Value2, Value3;//Global Variables
        public Program(T Value1, T Value2, T Value3)//Constructor used as reference for the global variables.
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.Value3 = Value3;
        }
        public static T maximumNumber(T Value1, T Value2, T Value3)//Generic Mathod T
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
        public static void Main(string[] args)
        {
            Program<int> intMax = new Program<int>(10, 8, 5);//object creation for integer data type.
            Program<double> doubleMax = new Program<double>(3.74, 5.94, 4.87);//object creation for the double data type.
            Program<string> stringMax = new Program<string>("A", "B", "C");//object creation for the string data type.
            Console.WriteLine("Maximum Integer Value = " + intMax);
            Console.WriteLine("Maximum Double Value = " + doubleMax);
            Console.WriteLine("Maximum String Value = " + stringMax);
        }
    }
}
