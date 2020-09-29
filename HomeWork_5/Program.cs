using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        static int[] myArray = { 0, 1, 2, 3, 4 };

        static void Main(string[] args)
        {
            Console.Write("Enter the Task number from 1 to 3: ");
            char taskNumber = Console.ReadKey().KeyChar;
            Console.Clear();

            Console.Write("You have the Array includes: |");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "|");

            Console.WriteLine();

            switch (taskNumber)
            {
                case '1':
                    Task_1();
                    break;
                case '2':
                    Task_2();
                    break;
                case '3':
                    Task_3();
                    break;
                default:
                    Console.WriteLine("\nThere is no such Task!");
                    break;
            }

            Console.Write("Now Your Array includes: |");

            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "|");

            Console.WriteLine();
        }

        static void Task_1()
        {
            Console.Write("Enter \"Up\" to increase Array size, or \"Down\" to decrease Array size: ");
            string resize = Console.ReadLine();

            switch (resize)
            {
                case "Up":
                    ChangeArray(ref myArray, true);
                    break;
                case "Down":
                    ChangeArray(ref myArray, false);
                    break;
                default:
                    Console.WriteLine("Unknown action!");
                    break;
            }
        }

        static void Task_2()
        {
            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("\nEnter index from 0 to 5: ");
            uint index = uint.Parse(Console.ReadLine());

            ChangeArray(ref myArray, value, index);
        }

        static void Task_3()
        {
            Console.Write("Which Array index you want to delete? \"First\", \"last\" or Enter index from 0 to 5: ");
            string resize = Console.ReadLine();

            switch (resize)
            {
                case "First":
                    ChangeArray(ref myArray, 0);
                    break;
                case "0":
                    ChangeArray(ref myArray, 0);
                    break;
                case "1":
                    ChangeArray(ref myArray, 1);
                    break;
                case "2":
                    ChangeArray(ref myArray, 2);
                    break;
                case "3":
                    ChangeArray(ref myArray, 3);
                    break;
                case "4":
                    ChangeArray(ref myArray, 4);
                    break;
                case "Last":
                    ChangeArray(ref myArray, 4);
                    break;
                default:
                    Console.WriteLine("Unknown action!");
                    break;
            }
        }

        static void ChangeArray(ref int[] array, bool increase)
        {
            int[] newArray = new int[array.Length + (increase ? +1 : -1)];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];

            array = newArray;
        }

        static void ChangeArray(ref int[] array, int value, uint index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i < index ? i : i + 1] = array[i];

            array = newArray;
        }

        static void ChangeArray(ref int[] array, uint index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = array[i < index ? i : i + 1];

            array = newArray;
        }
    }
}
