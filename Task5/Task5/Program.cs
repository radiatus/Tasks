using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.	Дан массив размера N. Найти максимальный из его локальных минимумов

namespace Task5
{
    class Program
    {
        static uint ReadUint()
        {
            uint nUint;
            while (!UInt32.TryParse(Console.ReadLine(), out nUint))
            {
                Console.Write("Введите правильно: ");
            }
            return nUint;
        }

        static int Rand(Random rng)
        {
            return rng.Next(100);
        }

        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            uint N = ReadUint();
            uint count = 0;
            uint[] mas = new uint[N];
            uint[] masM = new uint[N];
            Random rng = new Random();

            for (uint i = 0; i < N; i++)
            {
                mas[i] = Convert.ToUInt32(Rand(rng));
            }

            for (uint i = 0; i < N; i++)
            {
                if (i == mas.LongLength - 1)
                    break;
                else if (i == 0)
                    continue;
               
                if ((mas[i] < mas[i+1])&&(mas[i] < mas[i - 1]))
                {
                    masM[count] = mas[i];

                    count++;
                }
            }
            Array.Sort(masM);
            Console.WriteLine(masM[masM.Length-1]);
            Console.ReadKey();
        }
    }
}
