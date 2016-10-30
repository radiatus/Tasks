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


        static bool M(int[,] matrix, int i, int j)
        {
            for (int count = 0; count < matrix.Length; count++)
            {
                for (int count2 = 0; count2 < matrix.Length; count2++)
                {
                    if ()
                    {

                        return true;
                    }
                    return false;
                   
                }
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
            
            int[,] matrix = new int[matrixSize, matrixSize];
            Random rnd = new Random();
            for (int count = 0; count < matrixSize;count++)
            {
                for (int count2 = 0; count2 < matrixSize; count2++)
                {
                    matrix[count, count2] = rnd.Next(0,100);
                }
            }



            int[,] matrix2 = new int[matrixSize, matrixSize];
            for (int count = 0; count < matrixSize; count++)
            {
                for (int count2 = 0; count2 < matrixSize; count2++)
                {
                    if (count == i && count2 == j && M(matrix, i, j))
                    {
                        matrix2[count, count2] = 1;
                    }
                    else
                    {
                      matrix2[count, count2] = 0;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
