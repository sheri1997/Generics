using System;

namespace Generics
{
    public class Program<T>where T: IComparable//Generic Class, IComparable is used as a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
    {
        public T[] Values;//array defined which can hold more than three parameters
        public Program(T[] Values)//constructor for variable reference.
        {
            this.Values = Values;
        }
        public T[] Sorting(T[] Values)
        {
            Array.Sort(Values);//using the predefined Sort method of the Predefind Array Class.
            return Values;
            
        }
        public T MaxValue(T[] Values)
        {
            var sort = Sorting(Values);//will be holding the sorted values of the Sorting Function.
            return sort[^1];//ranged operator used to give here the last value of the array since the array is sorted.
        }
        public T MaxMethod()
        {
            var maximum = MaxValue(this.Values);//reference to the global array which is now sorted.
            return maximum;
        }
        public static void Main(string[] args)
        {
            int[] intArray = { 10, 8, 5, 7, 2, 9 };
            double[] doubleArray = { 20.4, 8.12, 6.14, 7.58, 4.95, 5.46 };
            string[] stringArray = {"A","B","C","D","E","F"};
            Program<int> intProgram = new Program<int>(intArray);
            Program<double> doubleProgram = new Program<double>(doubleArray);
            Program<string> stringProgram = new Program<string>(stringArray);
            Console.WriteLine("Maximum Integer Number = " + intProgram.MaxMethod());
            Console.WriteLine("Maximum Double Number = " + doubleProgram.MaxMethod());
            Console.WriteLine("Maximum String Value = " + stringProgram.MaxMethod());
        }
    }
}
