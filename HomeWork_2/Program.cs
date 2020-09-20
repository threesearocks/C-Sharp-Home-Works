using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter triangle size: ");
            int triangleSize = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i <= triangleSize; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("#");

                    Console.SetCursorPosition(j, triangleSize * 2 + 3 - i);
                    Console.Write("#");

                    Console.SetCursorPosition(triangleSize - i + j, triangleSize * 2 + 4 + i);
                    Console.Write("#");

                    Console.SetCursorPosition(triangleSize - i + j, triangleSize * 4 + 7 - i);
                    Console.Write("#");
                }
            }

            Console.SetCursorPosition(0, triangleSize * 4 + 10);
        }
    }
}
