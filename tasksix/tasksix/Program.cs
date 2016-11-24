using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
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


        static bool Neighbor(int[,] matrix, int i, int j)
        {
            int countT = 0;
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int ii = i - 1; ii <= i + 1; ii++)
                if (ii >= 0 && ii < rowCount)
                    for (int jj = j - 1; jj <= j + 1; jj++)
                        if (jj >= 0 && jj < columnCount && matrix[ii, jj] == matrix[i, j])
                                countT++;
            if (countT > 3)
                return true;
             else
                return false;
        }


        static void FillingMatrixTwo(int[,] matrix, int[,] matrix2)
        {
			int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int count = 0; count < rowCount; count++)
            {
                for (int count2 = 0; count2 < columnCount; count2++)
                {
                    if (Neighbor(matrix, count, count2) == true)
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
        

        static int[,] GetMas(string wayToFile)
          {
            Console.WriteLine("Введите количество строк матрицы: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбов матрицы: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            string[] lines = File.ReadAllLines(wayToFile).Take(10).ToArray();

            int[,] arr = new int[size1, size2];
            for (int i = 0; i < size1; i++)
            {
                int[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < size2; j++)
                {
                    arr[i, j] = row[j];
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[,] matrix = GetMas(Console.ReadLine());
            int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
            FillingMatrixTwo(matrix, matrix2);

            Console.ReadKey();
        }
    }
}
