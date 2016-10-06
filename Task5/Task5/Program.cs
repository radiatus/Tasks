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
            uint[] mas = new uint[N];
            Random rng = new Random();

            for (uint i = 0;i<N;i++)
            {
                mas[i] = Convert.ToUInt32(Rand(rng));
            }

            foreach (uint count in mas)
            {
                Console.WriteLine(count);
            }

            Console.ReadKey();
        }
    }
}
