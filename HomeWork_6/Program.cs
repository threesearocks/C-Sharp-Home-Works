using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 0, 1, 2, 3, 4, 9 };
            int MyValue = 10298;

            Console.Write("My Array is: ");
            PrintArray(myArray);

            int sumArray = SumArray(myArray);
            Console.WriteLine("Sum of the all Array elements is: " + sumArray);

            Console.WriteLine("\nMy Value is: " + MyValue);
            int sumDigits = SumDigits(MyValue);
            Console.WriteLine("Sum of the all Value digits: " + sumDigits + "\n");
        }

        static void PrintArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                Console.Write("|" + array[index] + (index == array.Length - 1 ? "|\n" : ""));
                PrintArray(array, index + 1);
            }
        }

        static int SumArray(int[] array, int index = 0)
        {
            if (index >= array.Length)
                return 0;

            return array[index] + SumArray(array, index + 1);
        }

        static int SumDigits(int value)
        {
            if (value < 10)
                return value;

            return value % 10 + SumDigits(value / 10);
        }
    }
}
