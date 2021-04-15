using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольник_паскаля
{
    class Program
    {
        static void Print(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] != 0) Console.Write($"{arr[i, j],4}");
                }
                Console.WriteLine();
            }


        }



        static void NewPrint(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = row * 4;


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(col, i);
                    string s = "+";
                    if (arr[i, j] != 0 && arr[i, j] % 2 != 0) Console.WriteLine($"{s,4}"); //Console.Write($"{arr[i, j],4}");
                    col += 4 * 2;
                }
                col = 4 * row - (4 * (i + 1));
                Console.WriteLine();
            }


        }
        static void Fill(int[,] arr)
        {
            Random r = new Random();
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                arr[i, 0] = 1;
                arr[i, i] = 1;
            }




            for (int i = 2; i < row; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    // arr[i, j] = r.Next(10);
                }

            }


        }

        static void Main()
        {
            Console.ReadLine();
            const int row = 120;

            int[,] matrix = new int[row, row];

            Fill(matrix);
            NewPrint(matrix);






            Console.ReadLine();
        }

    }
}
