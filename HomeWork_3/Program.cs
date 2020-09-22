﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of values in Array:\t");
            int valuesCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[valuesCount];
            int smallestValue = 0;
            int evenValuesSum = 0;

            Console.WriteLine("Enter Array values: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                    smallestValue = myArray[i];
                else
                    if (myArray[i] < smallestValue)
                        smallestValue = myArray[i];

                if (myArray[i] % 2 == 0)
                    evenValuesSum += myArray[i];
            }

            Console.Write("Array countdoun is: ");
            for (int i = myArray.Length; i > 0; i--)
            {
                Console.Write(myArray[i - 1] + " ");
            }
            Console.WriteLine();

            Console.Write("Sum of Even values of Array is: " + evenValuesSum);
            Console.WriteLine();

            Console.Write("Smallest value of Array is: " + smallestValue);
            Console.WriteLine();
        }
    }
}
