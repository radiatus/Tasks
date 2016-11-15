using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasksix
{
    class Program
    {
        static int ReadInt()
        {
            int nInt;
            while (!Int32.TryParse(Console.ReadLine(), out nInt))
            {
                Console.Write("Введите правильно: ");
            }
            return nInt;
        }


        static bool Equlse(int[,] matrix, int i, int j)
        {
            int countT = 0;
            int leng = Convert.ToInt32(Math.Sqrt(matrix.Length)) - 1;

             if (i != 0 && matrix[i - 1, j] == matrix[i, j])
                countT++;
             if(i != 0 && j != 0 && matrix[i - 1, j - 1] == matrix[i, j])
                countT++;
             if (j != 0 && matrix[i, j - 1] == matrix[i, j])
                countT++;
             if (i != leng && matrix[i + 1, j] == matrix[i, j])
                countT++;
             if (j != leng && matrix[i, j + 1] == matrix[i, j])
                countT++;
             if (i != leng && j != leng && matrix[i + 1, j + 1] == matrix[i, j])
                countT++;
             if (countT > 2)
                return true;
             else
                return false;
        }
      
        static void RandInMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int count = 0; count < Math.Sqrt(matrix.Length); count++)
            {
                for (int count2 = 0; count2 < Math.Sqrt(matrix.Length); count2++)
                {
                    matrix[count, count2] = rnd.Next(0, 5);
                    Console.Write(matrix[count, count2] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        static void M1toM2(int[,] matrix, int[,] matrix2, int i, int j)
        {
            for (int count = 0; count < Math.Sqrt(matrix.Length); count++)
            {
                for (int count2 = 0; count2 < Math.Sqrt(matrix.Length); count2++)
                {
                    if (count == i && count2 == j && Equlse(matrix, i, j) == true)
                    {
                        matrix2[count, count2] = 1;
                        Console.Write(matrix2[count, count2] + " ");
                    }
                    else
                    {
                        matrix2[count, count2] = 0;
                        Console.Write(matrix2[count, count2] + " ");
                    }
                }
                Console.WriteLine("");
            }
        }

    static void Main(string[] args)
        {
            Console.Write("Размер: ");
            int matrixSize = ReadInt();
            Console.Write("i: ");
            int i = ReadInt();
            Console.Write("j: ");
            int j = ReadInt();
            Console.WriteLine("");

            int[,] matrix = new int[matrixSize, matrixSize];
            RandInMatrix(matrix);

            int[,] matrix2 = new int[matrixSize, matrixSize];
            M1toM2(matrix, matrix2, i, j);
            
            Console.ReadKey();
        }
    }
}
