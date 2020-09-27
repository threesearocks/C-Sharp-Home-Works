using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            Console.Write("Enter symbol: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.Write("\nEnter count of symbols: ");
            uint symbolsCount = uint.Parse(Console.ReadLine());

            PrintSymbols(symbol, symbolsCount);

            //Task 2

            int[] myArray = GetRandomArray(10, -10, 20);
            int index;

            Console.Write("\nEnter your value: ");
            int value = int.Parse(Console.ReadLine());

            index = FindeIndex(myArray, value);

            if (index >= 0)
            {
                Console.WriteLine("Index of your value is " + index);
            }
            else
            {
                Console.WriteLine("Array does not contain value " + value);
            }
        }

        static void PrintSymbols(char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;
        }

        static int FindeIndex(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
