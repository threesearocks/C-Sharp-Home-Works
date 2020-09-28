using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Task number: ");
            char taskNumber = Console.ReadKey().KeyChar;

            switch (taskNumber)
            {
                case '1':
                    Console.Clear();
                    Task_1();
                    break;
                case '2':
                    Console.Clear();
                    Task_2();
                    break;
                default:
                    Console.WriteLine("\nThere is no such Task!");
                    break;
            }

        }

        static void Task_1()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            //string[] myArray = { "one", "two", "three", "four", "five" };

            Console.Write("Enter \"Up\" to increase Array size, or \"Down\" to decrease Array size: ");
            string resize = Console.ReadLine();

            switch (resize)
            {
                case "Up":
                    Resize(ref myArray, true);
                    break;
                case "Down":
                    Resize(ref myArray, false);
                    break;
                default:
                    Console.WriteLine("Unknown action!");
                    break;
            }

            Console.Write("The Array includes: |");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "|");
                //Console.Write((myArray[i] ?? "(empty field)") + "|");

            Console.WriteLine();
        }

        static void Resize<T>(ref T[] array, bool increase)
        {
            T[] newArray = new T[array.Length + (increase ? +1 : -1)];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];

            array = newArray;
        }


        static void Task_2()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("\nEnter index: ");
            uint index = uint.Parse(Console.ReadLine());

            if (index < myArray.Length + 1)
            {
                Insert(ref myArray, value, index);

                Console.Write("The Array includes: |");

                for (int i = 0; i < myArray.Length; i++)
                    Console.Write(myArray[i] + "|");
            }
            else
                Console.WriteLine("\nThere is no such Index!");

            Console.WriteLine();
        }

        static void Insert(ref int[] array, int value, uint index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i < index ? i : i + 1] = array[i];

            array = newArray;
        }
    }
}
